using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoutineFitness.Models;
using RoutineFitness.Models.ViewModels;

namespace RoutineFitness.Controllers
{
    public class ActivityController : Controller
    {
        private IRoutineFitnessRepository repository;

        public ActivityController(IRoutineFitnessRepository repo)
        {
            repository = repo;
        }

        public ViewResult ShowList(int listActivities)
        {
            return View(new SavedWorkoutViewModel
            {
                // Selecintg the activities associated to a workout ID, which is what makes up the entire routine
                Activities = repository.Activities
                            .Where(a => a.WorkoutId == listActivities),

                // Joining the tables so I can enumerate through a string of workout names based on the workout id
                // This allows the above Activities to have a name to the lift associated to the activity
                LiftName = repository.Lifts
                        .Join(repository.Activities,
                        l => l.LiftId,
                        a => a.LiftId,
                        (l, a) => new { Lift = l, Activity = a})
                        .Where(la => la.Activity.WorkoutId == listActivities)
                        .Select(la => la.Lift.LiftName)
            }); 
        }
    }
}
