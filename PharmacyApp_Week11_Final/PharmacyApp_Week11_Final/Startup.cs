using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PharmacyApp_Week11_Final.Models.DBGenerated;

namespace PharmacyApp_Week11_Final
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

            // Configure application to use the MVC design pattern
            services.AddControllersWithViews().AddNewtonsoftJson();

            // configure application to use SQL server (using Database-First approach)
            services.AddDbContext<PatientContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("PatientDBContext")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Patient}/{action=PatientList}/{patientId?}");
            });

            /*
             * commend that generates entity classes from a Sql server db
             PM> Scaffold-DbContext -Connection name=AccountPayableContext 
            -Provider Microsoft.EntityFrameworkCore.SqlServer 
            -OutputDir Models\DBGenerated -DataAnnotations –Force
             */
        }
    }
}
