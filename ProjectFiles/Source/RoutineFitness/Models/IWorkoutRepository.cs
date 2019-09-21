using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutineFitness.Models
{
    public interface IWorkoutRepository
    {
        IQueryable<Workout> Workouts { get; }
    }
}
