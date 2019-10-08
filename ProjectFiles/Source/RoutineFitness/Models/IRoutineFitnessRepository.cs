using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutineFitness.Models
{
    public interface IRoutineFitnessRepository
    {
        IQueryable<Account> Accounts { get; }
        IQueryable<Activity> Activities { get; }
        IQueryable<Lift> Lifts { get; }
        IQueryable<Workout> Workouts { get; }

        void SaveLift(Lift lift);

        Lift DeleteLift(int liftId);
    }
}
