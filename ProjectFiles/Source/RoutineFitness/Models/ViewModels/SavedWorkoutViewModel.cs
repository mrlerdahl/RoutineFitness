using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutineFitness.Models.ViewModels
{
    public class SavedWorkoutViewModel
    {
        public IEnumerable<Workout> Workouts { get; set; }
        public IEnumerable<Lift> Lifts { get; set; }
        public IEnumerable<Activity> Activities { get; set; }

        public IEnumerable<string> LiftName { get; set; }

    }
}
