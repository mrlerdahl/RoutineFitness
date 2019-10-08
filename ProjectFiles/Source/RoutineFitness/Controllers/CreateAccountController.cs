using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using RoutineFitness.Models;
using Microsoft.AspNetCore.Authorization;

namespace RoutineFitness.Controllers
{
    
    public class CreateAccountController : Controller
    {
        private UserManager<IdentityUser> userManager;

        public CreateAccountController(UserManager<IdentityUser> usrMgr)
        {
            userManager = usrMgr;
        }

        public ViewResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = model.UserName,
                    Email = model.Email
                };
                IdentityResult result
                    = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }

    }
}
