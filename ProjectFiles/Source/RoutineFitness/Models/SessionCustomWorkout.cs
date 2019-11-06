using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using RoutineFitness.Infrastructure;

namespace RoutineFitness.Models
{
    public class SessionCustomWorkout: CustomWorkout
    {
        public static CustomWorkout GetCustomWorkout(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;
            SessionCustomWorkout customWorkout = session?.GetJson<SessionCustomWorkout>("CustomWorkout") ?? new SessionCustomWorkout();
            customWorkout.Session = session;
            return customWorkout;
        }

        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddActivity(Activity activity, string liftName)
        {
            base.AddActivity(activity, liftName);
            Session.SetJson("CustomWorkout", this);
        }

        public override void RemoveActivity(int liftId)
        {
            base.RemoveActivity(liftId);
            Session.SetJson("CustomWorkout", this);
        }

        public override void Clear()
        {
            base.Clear();
            Session.Remove("CustomWorkout");
        }
    }
}
