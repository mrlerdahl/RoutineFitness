using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoutineFitness.Models;

namespace RoutineFitness.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LogIn()
        {

            return View();
        }

        public IActionResult SignUp()
        {

            return View();
        }

        public IActionResult MuscleGroups()
        {
            return View();
        }

        public IActionResult CreateRoutines()
        {
            return View();
        }
    }
}
