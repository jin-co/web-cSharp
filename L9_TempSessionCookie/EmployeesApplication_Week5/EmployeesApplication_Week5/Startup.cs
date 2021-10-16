using EmployeesApplication_Week5.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EmployeesApplication_Week5
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
            /* required to make use of Session and Cookies(by default it is not enabled)
             * must be added before calling the 'services.AddControllersWithViews()'
             */
            services.AddMemoryCache();
            services.AddSession();
            /* session with options */
            //services.AddSession(options =>
            //{
            //    options.IdleTimeout = TimeSpan.FromSeconds(60 * 5);
            //    options.Cookie.HttpOnly = false;
            //    options.Cookie.IsEssential = true;
            //});



            // Adding the MVC (Models/Views/Controllers) functionality to the application.
            services.AddControllersWithViews();

            // Configuring the application to use a database as specified in the appsettings.json file.
            services.AddDbContext<EmployeeContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("EmployeeContext")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            // to specify to the middle ware of using session state
            // Needs to be called before configuring endpoint below
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                // Need this controller configuration to handle a third segment in our routing paths that takes
                // in an optional "sortOrder" query string parameter. Specifically used for sorting employee records
                // in the employee list entries.
                endpoints.MapControllerRoute(
                    name: "EmployeeSortOrder",
                    pattern: "{controller=Employees}/{action=Index}/{sortOrder?}");

                // All other routing paths make use of this default routing configuration.
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
