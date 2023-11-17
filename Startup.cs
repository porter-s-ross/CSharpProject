using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CSharpProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CSharpProject
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
            services.AddDbContext<MyContext>(options => options.UseMySql(Configuration["DBInfo:ConnectionString"]));
            services.AddControllersWithViews();
            services.AddSession();

            services.AddLogging(builder =>
            {
                builder.AddConsole();  // or other logging providers
            });
            // Admin authentication scheme
            // services.AddAuthentication("AdminScheme")
            //     .AddCookie("AdminScheme", options =>
            //     {
            //         options.LoginPath = "/Admin"; // Update this with the path to your admin login page
            //             // Add other admin-specific configuration if needed
            //         options.AccessDeniedPath = "/Admin";
            //     });


            // // Authorization policy for admin users
            // services.AddAuthorization(options =>
            // {
            //     options.AddPolicy("AdminPolicy", policy =>
            //         policy.RequireRole("Admin"));
            // });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                name: "adminLogin",
                pattern: "Admin/AdminLogin",
                defaults: new { controller = "Admin", action = "AdminLogin" });

                endpoints.MapControllerRoute(
                    name: "adminDashboard",
                    pattern: "Admin/AdminDashboard",
                    defaults: new { controller = "Admin", action = "AdminDashboard" });
            });

        }
    }
}