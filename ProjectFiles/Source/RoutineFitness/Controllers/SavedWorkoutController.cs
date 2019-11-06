using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoutineFitness.Models;
using RoutineFitness.Models.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace RoutineFitness.Controllers
{
    public class SavedWorkoutController : Controller
    {
        private IRoutineFitnessRepository workoutRepository;
        private readonly UserManager<IdentityUser> userManager;

        public SavedWorkoutController (IRoutineFitnessRepository workoutRepo, UserManager<IdentityUser> userManager)
        {
            workoutRepository = workoutRepo;
            this.userManager = userManager;
        }

        public ViewResult SavedWorkout()
        {
            if(userManager.GetUserId(User) == null)
            {
                return View();
            }

            return View(workoutRepository.Workouts.Where(w => w.UserNumber == userManager.GetUserId(User)));
        }


        public ViewResult NavSearch()
        {
            return View("Search");
        }

        public ViewResult Search(string searchInput)
        {
            if (string.IsNullOrEmpty(searchInput))
            {
                return View(workoutRepository.Workouts);
            }

            return View(workoutRepository.Workouts
                        .Where(s => s.WorkoutName.Contains(searchInput)));
                        
        }

        [HttpPost]
        public IActionResult AddFavorite(int workoutId, string workoutName)
        {
            workoutRepository.SaveWorkout(workoutName, userManager.GetUserId(User), workoutId);

            return RedirectToAction("SavedWorkout");

        }

    }
}
