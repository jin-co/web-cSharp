using Microsoft.AspNetCore.Mvc;

namespace CheatSheetCSharp.Session.Controllers
{
    [Area("Session")]
    public class HomeController : Controller
    {
        // Simply process and render the Index.cshtml view page from the Home controller view folder.
        public IActionResult Index()
        {
            return View();
        }
    }
}
