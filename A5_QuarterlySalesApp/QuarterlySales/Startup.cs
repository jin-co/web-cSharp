using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using QuarterlySales.Models;
using Microsoft.AspNetCore.Identity;

namespace QuarterlySales
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting(options => {
                options.LowercaseUrls = true;
                options.AppendTrailingSlash = true;
            });

            services.AddMemoryCache();
            services.AddSession();

            services.AddControllersWithViews().AddNewtonsoftJson();

            services.AddDbContext<SalesContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SalesContext")));
            
            // Adds identity service
            //services.AddIdentity<User, IdentityRole>()
            //    .AddEntityFrameworkStores<SalesContext>()
            //    .AddDefaultTokenProviders();

            // Identity with options
            services.AddIdentity<User, IdentityRole>(options => {
                options.Password.RequiredLength = 6;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<SalesContext>()
            .AddDefaultTokenProviders();

        }

        // Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseSession();

            // identity
            app.UseAuthentication();
            
            app.UseRouting();

            app.UseAuthorization();  // after routing before endpoint

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "pagesortfilter",
                    pattern: "{controller=Home}/{action=Index}/page/{pagenumber}/size/{pagesize}/sort/{sortfield}/{sortdirection}/filterby/employee-{employee}/year-{year}/qtr-{quarter}");


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            SalesContext.CreateAdminUser(app.ApplicationServices).Wait();

        }
    }
}
