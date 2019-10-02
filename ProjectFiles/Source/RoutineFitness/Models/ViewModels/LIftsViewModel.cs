using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RoutineFitness.Models
{
    public class LiftsViewModel
    {
        public IEnumerable<Lift> Lifts { get; set; }

        public string CurrentLiftName { get; set; }
    }
}
