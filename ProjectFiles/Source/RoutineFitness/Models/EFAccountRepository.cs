using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutineFitness.Models
{
    public class EFAccountRepository : IAccountRepository
    {
        private RoutineFitnessContext context;

        public EFAccountRepository(RoutineFitnessContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Account> Accounts => context.Accounts;
    }
}
