using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoutineFitness.Models
{
    public class Lift
    {
        [Key]
        public int LiftId { get; set; }

        public string Category { get; set; }

        public string LiftName { get; set; }

        public string VideoUrl { get; set; }

        public string ImageUrl { get; set; }

        public string LiftDescription { get; set; }

        public ICollection<Activity> Activities { get; set; }

    }
}
