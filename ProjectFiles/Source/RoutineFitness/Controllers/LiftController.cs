using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoutineFitness.Models;



namespace RoutineFitness.Controllers
{
    public class LiftController : Controller
    {
        private IRoutineFitnessRepository repository;

        public LiftController(IRoutineFitnessRepository repo)
        {
            repository = repo;
        }

       

        public ViewResult Muscle(string category)
        {
            // Filters lifts based on what the category the user clicks on
            return View(new LiftsViewModel { Lifts = repository.Lifts
                                                        .Where(p => category == null || p.Category == category) });
        }

        public ViewResult LiftDetail(string name)
        {
            // Displays the lift detials when a user clicks on a specific lift
            return View(new LiftsViewModel { Lifts = repository.Lifts
                                                        .Where(p => p.LiftName == name)});
        }
    }
}
// 