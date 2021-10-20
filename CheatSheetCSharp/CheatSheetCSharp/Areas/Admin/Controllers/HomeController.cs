using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheatSheetCSharp.Areas.Admin.Controllers
{
    // Attribute must be needed to associate the controller with the area
    // attribute name and the area route in Startup.cs must match
    [Area("Admin")]
    public class HomeController : Controller
    {      
        //[Route("[area]/[controller]s/{id?}")]  // controller / controllers both work
        public IActionResult Index()
        {
            return View();
        }
    }
}
