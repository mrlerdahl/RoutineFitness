using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace RoutineFitness.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            RoutineFitnessContext context = app.ApplicationServices.GetRequiredService<RoutineFitnessContext>();
            context.Database.Migrate();
            if (!context.Accounts.Any())
            {
                context.AddRange(
                    new Account { UserName = "SwoleBro", Password = "P@ssword", FirstName = "Eddie", LastName = "Baker", Email = "something@some.com" },
                    new Account { UserName = "PrincessPeach", Password = "Passw0rd", FirstName = "Holly", LastName = "Sterner", Email = "random@random.com" },
                    new Account { UserName = "TheForce", Password = "Pa$$word", FirstName = "Stan", LastName = "Martin", Email = "email@email.com" }
                    );
            }
                 context.SaveChanges();

            context.Database.Migrate();
            if (!context.Lifts.Any())
            {

                context.AddRange(
                            new Lift
                            {
                                Category = "Legs",
                                LiftName = "Squats",
                                LiftDescription = "This is just a test description",
                                VideoUrl = "/images/Lifts/Legs/SquatVid1.mp4",
                                ImageUrl = "/images/Lifts/Legs/SquatPic2.jpg"
                            },
                            new Lift
                            {

                                Category = "Legs",
                                LiftName = "Front Squat",
                                LiftDescription = "This is just a test description",
                                VideoUrl = "/images/Lifts/Legs/FrontSquatVid1.mp4",
                                ImageUrl = "/images/Lifts/Legs/FrontSquatPic1.jpg"
                            },
                            new Lift
                            {

                                Category = "Legs",
                                LiftName = "Bulgarian Split Squat",
                                LiftDescription = "This is just a test description",
                                VideoUrl = "/images/Lifts/Legs/BulgarianSpliSquatVid.mp4",
                                ImageUrl = "/images/Lifts/Legs/BulgarianSpliSquatPic.jpg"
                            },
                            new Lift
                            {

                                Category = "Legs",
                                LiftName = "Deadlift",
                                LiftDescription = "This is just a test description",
                                VideoUrl = "/images/Lifts/Legs/DeadLiftVid1.mp4",
                                ImageUrl = "/images/Lifts/Legs/DeadLiftPic1.jpg"
                            },
                            new Lift
                            {

                                Category = "Legs",
                                LiftName = "Barbell Lunges",
                                LiftDescription = "This is just a test description",
                                VideoUrl = "/images/Lifts/Legs/BBLungesVid.mp4",
                                ImageUrl = "/images/Lifts/Legs/BBLungesPic.jpg"
                            },
                            new Lift
                            {

                                Category = "Back",
                                LiftName = "Barbell Shrug",
                                LiftDescription = "This is just a test description",
                                VideoUrl = "/images/Lifts/Back/BBShrugsVid.mp4",
                                ImageUrl = "/images/Lifts/Back/BBShrugsPic.jpg"
                            },
                            new Lift
                            {

                                Category = "Back",
                                LiftName = "Landmine Row",
                                LiftDescription = "This is just a test description",
                                VideoUrl = "/images/Lifts/Back/LandmineRowVid.mp4",
                                ImageUrl = "/images/Lifts/Back/LandmineRowPic1.jpg"
                            },
                            new Lift
                            {

                                Category = "Biceps",
                                LiftName = "Barbell Curl",
                                LiftDescription = "This is just a test description",
                                VideoUrl = "/images/Lifts/Biceps/BBCurlVid1.mp4",
                                ImageUrl = "/images/Lifts/Biceps/BBCurlPic1.jpg"
                            },
                            new Lift
                            {

                                Category = "Chest",
                                LiftName = "Bench Press",
                                LiftDescription = "This is just a test description",
                                VideoUrl = "/images/Lifts/Chest/BenchPressVid1.mp4",
                                ImageUrl = "/images/Lifts/Chest/BenchPressPic1.jpg"
                            },
                            new Lift
                            {

                                Category = "Chest",
                                LiftName = "Incline Press",
                                LiftDescription = "This is just a test description",
                                VideoUrl = "/images/Lifts/Chest/InclinePressVid.mp4",
                                ImageUrl = "/images/Lifts/Chest/InclinePressPic.jpg"
                            },
                            new Lift
                            {

                                Category = "Glutes",
                                LiftName = "Barbell Hip Thrusters",
                                LiftDescription = "This is just a test description",
                                VideoUrl = "/images/Lifts/Glutes/BBHipThrusterVid1.mp4",
                                ImageUrl = "/images/Lifts/Glutes/BBHipThrusterPic.jpg"
                            },
                            new Lift
                            {

                                Category = "Shoulders",
                                LiftName = "Barbell Standing Shoulder Press",
                                LiftDescription = "This is just a test description",
                                VideoUrl = "/images/Lifts/Shoulders/BBShoulderPressVid.mp4",
                                ImageUrl = "/images/Lifts/Shoulders/BBShoulderPressPic.jpg"
                            },
                            new Lift
                            {

                                Category = "Shoulders",
                                LiftName = "Landmine Single Arm Press",
                                LiftDescription = "This is just a test description",
                                VideoUrl = "/images/Lifts/Shoulders/LandmineSingleArmPressVid.mp4",
                                ImageUrl = "/images/Lifts/Shoulders/LandmineSingleArmPressPic.jpg"
                            },
                            new Lift
                            {

                                Category = "Trcieps",
                                LiftName = "Close Grip Press",
                                LiftDescription = "This is just a test description",
                                VideoUrl = "/images/Lifts/Triceps/CloseGripPressVid.mp4",
                                ImageUrl = "/images/Lifts/Triceps/CloseGripPressPic1.jpg"
                            },
                            new Lift
                            {

                                Category = "Triceps",
                                LiftName = "One Arm Tricep Kick Backs",
                                LiftDescription = "This is just a test description",
                                VideoUrl = "/images/Lifts/Triceps/OneArmTricepKickBackspic.mp4",
                                ImageUrl = "/images/Lifts/Triceps/OneArmTricepKickBacksVid.jpg"
                            },
                            new Lift
                            {

                                Category = "Triceps",
                                LiftName = "One Arm Tricep Pull Down",
                                LiftDescription = "This is just a test description",
                                VideoUrl = "/images/Lifts/Triceps/OneArmTricepPullDownVid.mp4",
                                ImageUrl = "/images/Lifts/Triceps/OneArmTricepPullDownpic.jpg"
                            },
                            new Lift
                            {

                                Category = "Triceps",
                                LiftName = "Triceps Over Head Extension",
                                LiftDescription = "This is just a test description",
                                VideoUrl = "/images/Lifts/Triceps/TricepOverHeadExtension2vid.mp4",
                                ImageUrl = "/images/Lifts/Triceps/TricepOverHeadExtension2Pic.jpg"
                            },
                            new Lift
                            {

                                Category = "Triceps",
                                LiftName = "Triceps Pull Down",
                                LiftDescription = "This is just a test description",
                                VideoUrl = "/images/Lifts/Triceps/TricepPullDownpic.mp4",
                                ImageUrl = "/images/Lifts/Triceps/TricepPullDownVid.jpg"

                            },
                            new Lift
                            {

                                Category = "Triceps",
                                LiftName = "Triceps Push Down",
                                LiftDescription = "This is just a test description",
                                VideoUrl = "/images/Lifts/Triceps/TricepPushDownVid.mp4",
                                ImageUrl = "/images/Lifts/Triceps/TricepPushDownpic.jpg"
                            }
                        );
            }
            context.SaveChanges();

            context.Database.Migrate();
            if (!context.Workouts.Any())
            {
                context.AddRange(
                   new Workout { WorkoutId = 1, UserId = 1, WorkoutName = "Leg Day"},
                   new Workout { WorkoutId = 2, UserId = 3, WorkoutName = "My Workout" },
                   new Workout { WorkoutId = 3, UserId = 2, WorkoutName = "Killer Workout" }
                   );
            }

            context.SaveChanges();

            context.Database.Migrate();
            if (!context.Activities.Any())
            {
                context.AddRange(
                    new Activity { WorkoutId = 1, LiftId = 1, Sets = 5, Reps = 5, Weight = 275,  Note = "This is a sample note"},
                    new Activity { WorkoutId = 2, LiftId = 1, Sets = 4, Reps = 15, Weight = 185, Note = "This is a sample note"},
                    new Activity { WorkoutId = 2, LiftId = 2, Sets = 5, Reps = 5, Weight = 400,  Note = "This is a sample note"},
                    new Activity { WorkoutId = 3, LiftId = 5, Sets = 5, Reps = 5, Weight = 225,  Note = "This is a sample note"},
                    new Activity { WorkoutId = 1, LiftId = 2, Sets = 4, Reps = 15, Weight = 350, Note = "This is a sample note"},
                    new Activity { WorkoutId = 3, LiftId = 18, Sets = 5, Reps = 5, Weight = 165, Note = "This is a sample note"},
                    new Activity { WorkoutId = 1, LiftId = 15, Sets = 5, Reps = 5, Weight = 165, Note = "This is a sample note"},
                    new Activity { WorkoutId = 2, LiftId = 10, Sets = 5, Reps = 5, Weight = 165, Note = "This is a sample note"},
                    new Activity { WorkoutId = 3, LiftId = 4, Sets = 5, Reps = 5, Weight = 165,  Note = "This is a sample note"},
                    new Activity { WorkoutId = 3, LiftId = 13, Sets = 5, Reps = 5, Weight = 165, Note = "This is a sample note"},
                    new Activity { WorkoutId = 2, LiftId = 18, Sets = 3, Reps = 15, Weight = 80, Note = "This is a sample note"},
                    new Activity { WorkoutId = 3, LiftId = 11, Sets = 5, Reps = 5, Weight = 165, Note = "This is a sample note"},
                    new Activity { WorkoutId = 1, LiftId = 8, Sets = 5, Reps = 5, Weight = 165,  Note = "This is a sample note"}
                    );
            }
             context.SaveChanges();

            

            

            

        }
        
    }
}
