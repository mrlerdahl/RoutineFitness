using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutineFitness.Models
{
    public class FakeLiftRepository : ILiftRepository
    {
        public IQueryable<Lift> Lifts => new List<Lift>
        {
            new Lift { LiftId = 1, Category = "Legs", LiftName = "Squats", LiftDescription = "This is just a test description", VideoUrl = "url to display video"},
            new Lift { LiftId = 2, Category = "Legs", LiftName = "Leg Press", LiftDescription = "This is just a test description", VideoUrl = "url to display video"},
            new Lift { LiftId = 3, Category = "Back", LiftName = "Barbell Row", LiftDescription = "This is just a test description", VideoUrl = "url to display video"},
            new Lift { LiftId = 4, Category = "Biceps", LiftName = "Hammer Curl", LiftDescription = "This is just a test description", VideoUrl = "url to display video"},
            new Lift { LiftId = 5, Category = "Chest", LiftName = "Bench Press", LiftDescription = "This is just a test description", VideoUrl = "url to display video"}
        }.AsQueryable<Lift>();
    }
}
