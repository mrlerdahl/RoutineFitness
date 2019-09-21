using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RoutineFitness.Models
{
    public class Workout
    {
        [Key]
        public int Id { get; set; }

        public int WorkoutId { get; set; }

        [ForeignKey("Activity")]
        public int ActivityId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public string WorkoutName { get; set; }

        public virtual ICollection<Activity> Activity { get; set; }

        public virtual Account User { get; set; }
    }
}
