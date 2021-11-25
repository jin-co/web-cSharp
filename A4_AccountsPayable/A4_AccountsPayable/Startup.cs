using A4_AccountsPayable.Models.DBGenerated;
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

namespace A4_AccountsPayable
{
    /*
     * Author: Kwangjin Baek
     * Date: 2021. Nov. 24.
     * Description: Invoice management application
     * with the functions to add, edit, or delete
     */
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

            // Configure application to use the MVC design pattern
            services.AddControllersWithViews().AddNewtonsoftJson();

            // configure application to use SQL server (using Database-First approach)
            services.AddDbContext<apContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("AccountPayableDBContext")));
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

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            /*
             * Scaffold-DbContext -Connection name=AccountPayableDBContext -Provider Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models\DBGenerated -DataAnnotations –Force
             */
        }
    }
}
