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
        private ILiftRepository repository;

        public LiftController(ILiftRepository repo)
        {
            repository = repo;
        }

       

        public ViewResult Muscle(string category)
        {
            return View(new LiftsViewModel { Lifts = repository.Lifts
                                                        .Where(p => category == null || p.Category == category) });
        }

        public ViewResult LiftDetail(string name)
        {
            return View(new LiftsViewModel { Lifts = repository.Lifts
                                                        .Where(p => p.LiftName == name)});
        }
    }
}
// 