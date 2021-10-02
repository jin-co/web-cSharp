using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routing.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return Content("Home controller, index action");
        }

        [Route("About")]
        public IActionResult About()
        {
            return Content("Home controller, about action");
        }

        [Route("Product/{cat?}")]
        public IActionResult ProductList()
        {
            return Content("Home controller, about action");
        }

        [NonAction]
        public IActionResult NotApprochableByUsers()
        {
            return Content("Home controller, about action");
        }
    }
}
