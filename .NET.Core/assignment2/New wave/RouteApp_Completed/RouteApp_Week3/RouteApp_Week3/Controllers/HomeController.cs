using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RouteApp_Week3.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return Content("Home controller, Index action.");
        }

        [Route("About")]
        public IActionResult About()
        {
            return Content("Home controller, About action.");
        }
    }
}
