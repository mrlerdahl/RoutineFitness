//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace RoutineFitness.Models
//{
//    public class FakeActivityRepository : IActivityReposityory
//    {
//        public IQueryable<Activity> Activities => new List<Activity>
//        {
//            new Activity { ActivityId = 1, LiftId = 1, Sets = 5, Reps = 5, Weight = 275},
//            new Activity { ActivityId = 2, LiftId = 1, Sets = 4, Reps = 15, Weight = 185},
//            new Activity { ActivityId = 3, LiftId = 2, Sets = 5, Reps = 5, Weight = 400},
//            new Activity { ActivityId = 4, LiftId = 5, Sets = 5, Reps = 5, Weight = 225},
//            new Activity { ActivityId = 5, LiftId = 2, Sets = 4, Reps = 15, Weight = 350},
//            new Activity { ActivityId = 6, LiftId = 3, Sets = 5, Reps = 5, Weight = 165}
//        }.AsQueryable<Activity>();
//    }
//}
