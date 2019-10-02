using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoutineFitness.Models
{
    public class Activity
    {
        [Key]
        public int ActivityId { get; set; }

        [ForeignKey("Workout")]
        public int WorkoutId { get; set; }
        public virtual Workout Workout { get; set; }

        [ForeignKey("Lift")]
        public int LiftId { get; set; }
        public virtual Lift Lift { get; set; }

        [Required(ErrorMessage = "Number of sets required")]
        public int Sets { get; set; }

        [Required(ErrorMessage = "Number of reps required")]
        public int Reps { get; set; }

        [Required(ErrorMessage = "Amount of weight reuired, 0 for no weight")]
        public int Weight { get; set; }

        public string Note { get; set; }

    }
}
