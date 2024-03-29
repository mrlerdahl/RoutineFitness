﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutineFitness.Models
{
    public class EFRoutineFitnessRepository : IRoutineFitnessRepository
    {
        private RoutineFitnessContext context;

        public EFRoutineFitnessRepository (RoutineFitnessContext ctx)
        {
            context = ctx;
        }


        //public IQueryable<Account> Accounts => context.Accounts;
        public IQueryable<Activity> Activities => context.Activities;
        public IQueryable<Lift> Lifts => context.Lifts;
        public IQueryable<Workout> Workouts => context.Workouts;

        public void SaveLift(Lift lift)
        {
            if (lift.LiftId == 0)
            {
                context.Lifts.Add(lift);
            }
            else
            {
                Lift dbEntry = context.Lifts
                        .FirstOrDefault(l => l.LiftId == lift.LiftId);
                if(dbEntry != null)
                {
                    dbEntry.LiftName = lift.LiftName;
                    dbEntry.Category = lift.Category;
                    dbEntry.LiftDescription = lift.LiftDescription;
                }
            }
            context.SaveChanges();
        }

        public Lift DeleteLift(int liftId)
        {
            Lift dbEntry = context.Lifts
                            .FirstOrDefault(l => l.LiftId == liftId);
            if(dbEntry != null)
            {
                context.Lifts.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public void SaveActivity(Activity activity)
        {
            //if(activity.ActivityId == 0)
            //{
                context.Activities.Add(activity);
            //}
            //else
            //{
            //    Activity dbEntry = context.Activities
            //                            .FirstOrDefault(a => a.ActivityId == activity.ActivityId);
            //    if(dbEntry != null)
            //    {
            //        dbEntry.LiftId = activity.LiftId;
            //        dbEntry.WorkoutId = activity.WorkoutId;
            //        dbEntry.Sets = activity.Sets;
            //        dbEntry.Reps = activity.Reps;
            //        dbEntry.Weight = activity.Weight;
            //        dbEntry.Note = activity.Note;
            //    }
            //}
            context.SaveChanges();
        }

        public void SaveWorkout(string workoutName, string userId, int workoutId)
        {
            context.Workouts.Add( new Workout
            {
                WorkoutId = workoutId,
                WorkoutName = workoutName,
                UserNumber = userId,
                UserId = 1
            });
            context.SaveChanges();
            
        }

    }
}
