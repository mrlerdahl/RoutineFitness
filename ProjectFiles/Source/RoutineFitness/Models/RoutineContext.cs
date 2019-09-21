using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RoutineFitness.Models
{
    public class RoutineContext : DbContext
    {
        public RoutineContext(DbContextOptions<RoutineContext> options) : base(options)
        {

        }

        public DbSet<Account> Account { get; set; }
        public DbSet<Lift> Lift { get; set; }
        public DbSet<Activity> Activity { get; set; }
        public DbSet<Workout> Workout { get; set; }
    }
}
