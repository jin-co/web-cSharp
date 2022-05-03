using Microsoft.AspNetCore.Mvc;

namespace BootstrapSandboxApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
