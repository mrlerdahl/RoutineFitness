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
        private IWorkoutRepository workoutRepository;
        //private IActivityReposityory activityReposityory;

        public SavedWorkoutController (IWorkoutRepository workoutRepo/*, IActivityReposityory activityRepo*/)
        {
            workoutRepository = workoutRepo;
            //activityReposityory = activityRepo;
        }

        public ViewResult SavedWorkout()
        {
            return View(workoutRepository.Workouts
                            
                                    .Distinct()
            );
        }

    }
}
