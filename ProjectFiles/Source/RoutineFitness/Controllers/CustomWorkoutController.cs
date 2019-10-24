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

        public CustomWorkoutController(IRoutineFitnessRepository repo, UserManager<IdentityUser> userManager)
        {
            repository = repo;
            this.userManager = userManager;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CustomWorkoutViewModel
            {
                CustomWorkout = GetCustomWorkout(),
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        public IActionResult CreateWorkout(string workoutName, string userId)
        {
            return View();
        }

        public IActionResult AddToList(string liftName, int liftId)
        {
            ViewBag.LiftName = liftName;
            ViewBag.liftId = liftId;
            ViewBag.WorkoutId = repository.Workouts.Max(w => w.WorkoutId) + 1;
            return View();
        }

        public RedirectToActionResult ShowList(int sets, int reps, int weight, string note, int liftId, string liftName, int workoutId, string returnUrl)
        {
            CustomWorkout customWorkout = GetCustomWorkout();

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
            SaveCustomWorkout(customWorkout);

            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveActivity(int liftId, string returnUrl)
        {
            CustomWorkout customWorkout = GetCustomWorkout();
            customWorkout.RemoveActivity(liftId);
            SaveCustomWorkout(customWorkout);

            return RedirectToAction("Index", new { returnUrl });
        }

        private CustomWorkout GetCustomWorkout()
        {
            CustomWorkout customeWorkout = HttpContext.Session.GetJson<CustomWorkout>("CustomWorkout") ?? new CustomWorkout();
            return customeWorkout;
        }

        private void SaveCustomWorkout(CustomWorkout customWorkout)
        {
            HttpContext.Session.SetJson("CustomWorkout", customWorkout);
        }

    }
}
