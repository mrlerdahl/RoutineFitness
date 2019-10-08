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

        [Required(ErrorMessage = "Enter a category")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Enter a lift name")]
        public string LiftName { get; set; }

        public string VideoUrl { get; set; }

        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Enter a description")]
        public string LiftDescription { get; set; }

        public ICollection<Activity> Activities { get; set; }

    }
}
