using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutineFitness.Models
{
    public class EFActivityRepository : IActivityReposityory
    {
        private RoutineFitnessContext context;

        public EFActivityRepository(RoutineFitnessContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Activity> Activities => context.Activities;
    }
}
