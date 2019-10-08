using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoutineFitness.Models;
using Microsoft.AspNetCore.Authorization;

namespace RoutineFitness.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IRoutineFitnessRepository repository;

        public AdminController(IRoutineFitnessRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index() => View(repository.Lifts);

        public ViewResult Edit(int liftId) => View(repository.Lifts
                                                    .FirstOrDefault(l => l.LiftId == liftId));

        [HttpPost]
        public IActionResult Edit(Lift lift)
        {
            if(ModelState.IsValid)
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
                    Redirect("Index");
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
            if(deleteLift != null)
            {
                TempData["message"] = $"{deleteLift.LiftName} was deleted";
            }
            return RedirectToAction("Index");
        }
    }
}
