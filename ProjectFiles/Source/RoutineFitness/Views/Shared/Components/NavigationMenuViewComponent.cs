using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoutineFitness.Models;
using RoutineFitness.Models.ViewModels;

namespace RoutineFitness.Views.Shared.Component
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private ILiftRepository repository;

        public NavigationMenuViewComponent(ILiftRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            return View(repository.Lifts
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
