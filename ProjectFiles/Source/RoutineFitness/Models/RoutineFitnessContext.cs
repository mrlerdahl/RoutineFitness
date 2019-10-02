using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace RoutineFitness.Models
{
    public class RoutineFitnessContext : DbContext
    {
        public RoutineFitnessContext(DbContextOptions<RoutineFitnessContext> options) : base(options)
        {

        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Lift> Lifts { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Workout> Workouts { get; set; }
    }
}
