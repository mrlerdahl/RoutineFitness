using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoutineFitness.Models;
using RoutineFitness.Models.ViewModels;

namespace RoutineFitness.Controllers
{
    public class SavedWorkoutController : Controller
    {
        private IRoutineFitnessRepository workoutRepository;

        public SavedWorkoutController (IRoutineFitnessRepository workoutRepo)
        {
            workoutRepository = workoutRepo;
        }

        public ViewResult SavedWorkout()
        {
            return View(workoutRepository.Workouts);
        }


        public ViewResult Search(string searchInput)
        {
            return View(workoutRepository.Workouts
                        .Where(s  => s.WorkoutName.Contains(searchInput)));
        }

    }
}
