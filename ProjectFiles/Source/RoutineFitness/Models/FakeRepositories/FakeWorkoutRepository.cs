//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace RoutineFitness.Models
//{
//    public class FakeWorkoutRepository : IWorkoutRepository
//    {
//        public IQueryable<Workout> Workouts => new List<Workout>
//        {
//            new Workout { Id = 1, WorkoutId = 1, WorkoutName = "Leg Day", ActivityId = 1, UserId = 1},
//            new Workout { Id = 2, WorkoutId = 1, WorkoutName = "Leg Day", ActivityId = 5, UserId = 1},
//            new Workout { Id = 3, WorkoutId = 2, WorkoutName = "My Workout", ActivityId = 2, UserId = 3},
//            new Workout { Id = 4, WorkoutId = 2, WorkoutName = "My Workout", ActivityId = 3, UserId = 3},
//            new Workout { Id = 5, WorkoutId = 3, WorkoutName = "Weight Lifting", ActivityId = 4, UserId = 2},
//            new Workout { Id = 6, WorkoutId = 3, WorkoutName = "Weight Lifting", ActivityId = 6, UserId = 2}
//        }.AsQueryable<Workout>();
//    }
//}
