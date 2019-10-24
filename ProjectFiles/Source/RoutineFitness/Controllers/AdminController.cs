using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoutineFitness.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using RoutineFitness.Models.ViewModels;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage;

namespace RoutineFitness.Controllers
{
    [Authorize(Roles = "ADMIN")]
    public class AdminController : Controller
    {
        private IRoutineFitnessRepository repository;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;

        public AdminController(IRoutineFitnessRepository repo, RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            repository = repo;
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        // Sends the admin to a page to view all lift details
        public ViewResult Index() => View(repository.Lifts);

        public ViewResult Edit(int liftId) => View(repository.Lifts
                                                    .FirstOrDefault(l => l.LiftId == liftId));

        [HttpPost]
        public IActionResult Edit(Lift lift)
        {
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;



                if (files.Count != 0)
                {
                    string videoPath = "wwwroot/Videos/";
                    string imagePath = "wwwroot/images/";

                    videoPath += files[0].FileName;
                    imagePath += files[1].FileName;

                    lift.VideoUrl = "/Videos/" + files[0].FileName;
                    lift.ImageUrl = "/images/" + files[1].FileName;

                    using (var fileStream = new FileStream(videoPath, FileMode.Create))
                    {
                        files[0].CopyTo(fileStream);
                    }

                    using (var fileStream = new FileStream(imagePath, FileMode.Create))
                    {
                        files[1].CopyTo(fileStream);
                    }

                    repository.SaveLift(lift);
                    TempData["message"] = $"{lift.LiftName} has been saved";
                }
                else
                {
                    repository.SaveLift(lift);
                }


                return RedirectToAction("Index");
            }
            else
            {
                return View(lift);
            }
        }

        public ViewResult Create() => View("Edit", new Lift());

        [HttpPost]
        public IActionResult Delete(int liftId)
        {
            Lift deleteLift = repository.DeleteLift(liftId);
            if (deleteLift != null)
            {
                TempData["message"] = $"{deleteLift.LiftName} was deleted";
            }
            return RedirectToAction("Index");
        }

        // To send the admin to a view to create roles
        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel role)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = role.RoleName
                };
                IdentityResult result = await roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

            }

            return View(role);
        }

        [HttpGet]
        public IActionResult ListRoles()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }

        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            var role = await roleManager.FindByIdAsync(id);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role Id = {id} cannot be found";
                return View("NotFound");
            }

            var model = new EditRoleViewModel
            {
                Id = role.Id,
                RoleName = role.Name
            };

            foreach (var user in userManager.Users)
            {
                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {
            var role = await roleManager.FindByIdAsync(model.Id);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role Id = {model.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                role.Name = model.RoleName;
                var result = await roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(model);
            }

        }

        [HttpGet]
        public async Task<IActionResult> EditUsersInRole(string roleId)
        {
            ViewBag.roleId = roleId;
            var role = await roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found";
                return View("NotFound");
            }

            var model = new List<UserRoleViewModel>();

            foreach (var user in userManager.Users)
            {
                var userRoleViewModel = new UserRoleViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName
                };

                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleViewModel.IsSelected = true;
                }
                else
                {
                    userRoleViewModel.IsSelected = false;
                }

                model.Add(userRoleViewModel);
            }

            return View(model);


        }

        [HttpPost]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, string roleId)
        {
            var role = await roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found";
                return View("NotFound");
            }

            for (int i = 0; i < model.Count; i++)
            {
                var user = await userManager.FindByIdAsync(model[i].UserId);

                IdentityResult result = null;

                if (model[i].IsSelected && !(await userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await userManager.AddToRoleAsync(user, role.Name);
                }
                else if(!model[i].IsSelected && await userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await userManager.RemoveFromRoleAsync (user, role.Name);
                }
                else
                {
                    continue;
                }

                if (result.Succeeded)
                {
                    if(i < (model.Count - 1))
                    {
                        continue;
                    }
                    else
                    {
                        return RedirectToAction("EditRole", new { Id = roleId });
                    }
                }
            }

            return RedirectToAction("EditRole", new { Id = roleId });
        }

    }
}
