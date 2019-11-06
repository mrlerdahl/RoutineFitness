using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutineFitness.Models
{
    public class CustomWorkout
    {
        public List<ActivityLine> lineCollection = new List<ActivityLine>();

        public int WorkoutId { get; set; }
        public virtual void AddActivity(Activity activity, string liftName)
        {
            lineCollection.Add(new ActivityLine
            {
                Activity = activity,
                LiftName = liftName
            });
        }

        public virtual void RemoveActivity(int liftId)
        {
            lineCollection.RemoveAll(a => a.Activity.LiftId == liftId);
        }

        public virtual void Clear() => lineCollection.Clear();

        //public virtual IEnumerable<ActivityLine> Line => lineCollection;
    }

    public class ActivityLine
    {
        public Activity Activity { get; set; }
        public string LiftName { get; set; }
    }
}
