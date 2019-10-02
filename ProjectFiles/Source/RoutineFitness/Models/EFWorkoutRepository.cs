using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutineFitness.Models
{
    public class EFWorkoutRepository : IWorkoutRepository
    {
        private RoutineFitnessContext context;

        public EFWorkoutRepository(RoutineFitnessContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Workout> Workouts => context.Workouts;
    }
}
