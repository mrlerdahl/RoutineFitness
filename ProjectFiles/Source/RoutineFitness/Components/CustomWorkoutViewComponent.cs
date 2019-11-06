using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoutineFitness.Models;

namespace RoutineFitness.Components
{
    public class CustomWorkoutViewComponent : ViewComponent
    {
        private CustomWorkout customWorkout;

        public CustomWorkoutViewComponent(CustomWorkout customWorkoutService)
        {
            customWorkout = customWorkoutService;
        }

        public IViewComponentResult Invoke()
        {
            return View(customWorkout);
        }
    }
}
