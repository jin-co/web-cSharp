using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheatSheetCSharp.Controllers
{
    //setting attribute for the entire controller
    //[Route("Retail/[Controller]/[Action]/{id ?}")]
    //[Route("Retail/[Controller]s/[Action]/{id ?}")]
    public class RouteController : Controller
    {
        /* return types
         * Content(string) -> returns plain text
         * 
         */
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Home()
        {
            return Content("Home");
        }
        
        
        public IActionResult Privacy()
        {
            return Content("Privacy");
        }

        public IActionResult Display(string id)
        {
            if (id == null)
            {
                return Content("No ID supplied.");
            }
            else
            {
                return Content("ID: " + id);
            }
        }

        //numbers are set to 0 by default when no parameter is passed
        public IActionResult Countdown(int id)
        {
            string content = "Counting down: \n";
            for (int i = id; i >= 0; i--)
            {
                content += i + "\n";
            }
            return Content(content);
        }

        //Attribute routing
        //-> specifies static route, not patterns
        //-> overrides all the settings in the 'Startup.cs'
        [Route("/")]
        public IActionResult Slash()
        {
            return Content("Route controller, slash action");
        }

        [Route("About")]  // for this to work, route needs to be '/About' without controller
        public IActionResult NotAbout(int id) // method name doesn't matter for 'About' is used
        {
            string content = "Counting down: \n";
            for (int i = id; i >= 0; i--)
            {
                content += i + "\n";
            }
            return Content(content);
        }

        [Route("Product/{cat?}")]
        public IActionResult ProductList()
        {
            return Content("Route controller, about action");
        }

        [NonAction]
        public IActionResult NotApprochableByUsers()
        {
            return Content("Route controller, about action");
        }

        [Route("[action]/{id?}")]  // flexible way that allows to match with method name
        public IActionResult CountdownAttributeRouting(int id)
        {
            return Content("About");
        }

        [Route("[controller]/[action]/{start}/{end?}/{message?}")]
        public IActionResult CountdownAttributeRouting(
            int start, int end = 0, string message = "")
        {
            string content = "Counting down: \n";
            for (int i = start; i >= end; i--)
            {
                content += i + "\n";
            }
            content += message;
            return Content(content);
        }

        //with static AssemblyLoadEventHandler dynamic data
        public IActionResult List(string id = "All", int page = 1, string sortBy = "Price")
        {
            return Content("Product controller, List action, " +
                "id: " + id +
                ", Page number: " + page +
                ", Sort By: " + sortBy);
        }
    }
}
