using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutineFitness.Models
{
    public class EFLiftRepository : ILiftRepository
    {
        private RoutineFitnessContext context;

        public EFLiftRepository(RoutineFitnessContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Lift> Lifts => context.Lifts;
    }
}
