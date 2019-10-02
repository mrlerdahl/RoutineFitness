using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoutineFitness.Models;

namespace RoutineFitness.Controllers
{
    public class ActivityController : Controller
    {
        private IActivityReposityory reposityory;

        public ActivityController (IActivityReposityory repo)
        {
            reposityory = repo;
        }

        public ViewResult ShowList(int listActivities)
        {
            return View(reposityory.Activities
                            .Where(x => x.WorkoutId == listActivities));
        }
    }
}
