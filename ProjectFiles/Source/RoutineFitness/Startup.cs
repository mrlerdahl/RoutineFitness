using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using RoutineFitness.Models;
using Microsoft.AspNetCore.Identity;



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
            //Data:RoutineFitnessConstr:ConnectionString
            //RoutineFitnessDB
            services.AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(Configuration["Data:RoutineFitnessIdentity:ConnectionString"]));
            //Data:RoutineFitnessIdentity:ConnectionString
            //IdentityDB
            services.AddIdentity<IdentityUser, IdentityRole>(opts => { opts.User.RequireUniqueEmail = true; })
                .AddEntityFrameworkStores<AppIdentityDbContext>()
                .AddDefaultTokenProviders();

            services.AddTransient<IRoutineFitnessRepository, EFRoutineFitnessRepository>();
            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();



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
            app.UseSession();
            app.UseAuthentication();
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
            //SeedData.EnsurePopulated(app);
            //IdentitySeedData.EnsurePopulated(app);
        }
    }
}
