using Microsoft.AspNetCore.Mvc;

namespace EmployeesApplication_Week5.Controllers
{
    public class HomeController : Controller
    {
        // Simply process and render the Index.cshtml view page from the Home controller view folder.
        public IActionResult Index()
        {
            return View();
        }
    }
}
