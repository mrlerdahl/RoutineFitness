using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoutineFitness.Models;
using RoutineFitness.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using RoutineFitness.Infrastructure;
using Microsoft.AspNetCore.Http;


namespace RoutineFitness.Controllers
{
    public class CustomWorkoutController : Controller
    {
        private IRoutineFitnessRepository repository;
        private readonly UserManager<IdentityUser> userManager;
        private CustomWorkout custom;

        public CustomWorkoutController(IRoutineFitnessRepository repo, UserManager<IdentityUser> userManager, CustomWorkout customWorkout)
        {
            repository = repo;
            this.userManager = userManager;
            custom = customWorkout;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CustomWorkoutViewModel
            {
                CustomWorkout = custom,
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        public IActionResult CreateWorkout(string workoutName, int workoutId)
        {
            string userNumber = userManager.GetUserId(User);
            

            if(userNumber == null)
            {
               return RedirectToAction("Create", "CreateAccount");
            }

            repository.SaveWorkout(workoutName, userNumber, workoutId);

            foreach (var item in custom.lineCollection)
            {
                repository.SaveActivity(item.Activity);
            }

            

            custom.Clear();

            return RedirectToAction("SavedWorkout", "SavedWorkout");
        }

        // This will take you to the page with a form asking for information and from there is passed into the ShowList method below
        public IActionResult AddToList(string liftName, int liftId)
        {
            ViewBag.LiftName = liftName;
            ViewBag.liftId = liftId;
            ViewBag.WorkoutId = repository.Workouts.Max(w => w.WorkoutId) + 1;
            return View();
        }

        // Once execute it is then actually added to the temporary list of activities
        // This works just like a shopping cart
        public RedirectToActionResult ShowList(int sets, int reps, int weight, string note, int liftId, string liftName, int workoutId, string returnUrl)
        {
            CustomWorkout customWorkout = custom;

            if (customWorkout.WorkoutId == 0)
            {
                customWorkout.WorkoutId = workoutId;
            }
            else if (workoutId != customWorkout.WorkoutId)
            {
                workoutId = customWorkout.WorkoutId;
            }

            Activity activity = new Activity
            {
                Sets = sets,
                Reps = reps,
                Weight = weight,
                Note = note,
                LiftId = liftId,
                WorkoutId = workoutId
            };
           
            customWorkout.AddActivity(activity, liftName);

            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveActivity(int liftId, string returnUrl)
        {
            CustomWorkout customWorkout = custom;
            customWorkout.RemoveActivity(liftId);
            //SaveCustomWorkout(customWorkout);

            return RedirectToAction("Index", new { returnUrl });
        }

        //private void SaveCustomWorkout(CustomWorkout customWorkout)
        //{
        //    HttpContext.Session.SetJson("CustomWorkout", customWorkout);
        //}

    }
}
