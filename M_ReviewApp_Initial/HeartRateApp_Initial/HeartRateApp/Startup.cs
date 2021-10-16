using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

using HeartRateApp.Models;

namespace HeartRateApp
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
            services.AddControllersWithViews();

            /* required to make use of Session(by default it is not enabled)
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


            // Add Sql server support:
            services.AddDbContext<HeartRateDbContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("HeartRateDbContext")));
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
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
