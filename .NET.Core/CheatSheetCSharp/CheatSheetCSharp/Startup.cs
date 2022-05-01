using CheatSheetCSharp.Filtering.Models;
using CheatSheetCSharp.Models.Data;
using CheatSheetCSharp.Session.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheatSheetCSharp
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
            // Configure application to use session services (e.g. Session variables and cookies)
            services.AddMemoryCache();
            services.AddSession();

            /* Methods for adding the MVC service */
            services.AddControllersWithViews();  // ASP.NET Core 2.2 and later
            //services.AddMvc();  // Versions prior to 2.2(includes unnecessary services)
            
            services.AddRouting(options =>
            {
                options.LowercaseUrls = true;  // makes it lower case
                options.AppendTrailingSlash = true;  // append trailing slash
            });

            // configure application to use SQL server (using Database-First approach)
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("CheatSheetContext")));
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            /* Methods for enabling and configuring routing */
            app.UseRouting();  // select endpoint if found

            app.UseAuthorization();

            app.UseSession();

            /* Methods for enabling and configuring routing */
            app.UseEndpoints(endpoints =>  // executes the endpoint selected by the routing
            {
                /* Routing order -> most specific(top) -> least specific(bottom) */

                /* attribute routing mapping */
                //endpoints.MapControllers();  
                // -> no need as it is automatically enabled(ASP.NET Core 3.0 or later)
                // -> just add this if attribute routing seems not working

                //endpoints.MapAreaControllerRoute(
                //    name: "admin",
                //    areaName: "Admin",
                //    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
                //);

                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllerRoute(
                      name: "areas",
                      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                    );
                });

                endpoints.MapControllerRoute(
                    name: "category_and_num",
                    //pattern: "{controller}/{action}/{cat}/{num}"
                    pattern: "{controller}/{action}/{cat}/Page{num}" // with static segment'Page'
                );

                endpoints.MapControllerRoute(
                    name: "paging_and_sorting",
                    pattern: "{controller}/{action}/{id}/Page{page}/sort-by-{sortby}" // with static segment'Page'
                );

                endpoints.MapControllerRoute(
                    name: "slug",
                    pattern: "{controller=Home}/{action=Index}/{id?}/{slug?}");

                /* default route */
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                /* another way to set the default route */
                //endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
