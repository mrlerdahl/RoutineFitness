using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using RoutineFitness.Models;


namespace RoutineFitness
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<RoutineFitnessContext>(options => options.UseSqlServer(Configuration["Data:RoutineFitnessConstr:ConnectionString"]));

            services.AddTransient<IAccountRepository, EFAccountRepository>();
            services.AddTransient<IActivityReposityory, EFActivityRepository>();
            services.AddTransient<ILiftRepository, EFLiftRepository>();
            services.AddTransient<IWorkoutRepository, EFWorkoutRepository>();
            services.AddMvc();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseCookiePolicy();
            app.UseMvcWithDefaultRoute();

            app.UseMvc(routes =>
            {

                routes.MapRoute(
                    name: null,
                    template: "{category}",
                    defaults: new { controller = "Lift", action = "Muscle" });

                routes.MapRoute(
                    name: null,
                    template: "",
                    defaults: new { controller = "Lift", action = "Muscle" });

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            SeedData.EnsurePopulated(app);
        }
    }
}
