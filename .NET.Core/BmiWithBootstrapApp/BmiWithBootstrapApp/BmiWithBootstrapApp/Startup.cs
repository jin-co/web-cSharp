using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
namespace BmiWithBootstrapApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // This line of code actually configures the application to handle the MVC approach. It looks towards
            // finding the "Controllers", "Models", and "Views" folder.
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                // This "Default" endpoint is a way of letting the application know where to route the application
                // to upon launching (i.e. "http://localhost:34532/Bmi/Index/"). The pattern is the important key
                // part in this configuration. It first calls the BmiController and then calls the "Index" method found
                // within the controller and returns the Index view.
                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller=Bmi}/{action=Index}/{id?}"
                );
            });
        }
    }
}
