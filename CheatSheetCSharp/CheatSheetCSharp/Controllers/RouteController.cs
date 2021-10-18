using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheatSheetCSharp.Controllers
{
    //setting attribute for the entire controller
    //[Route("Retail/[Controller] /[Action] /{id ?}")]
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
        
        //Attribute routing -> overrides all the setting in the method
        [Route("[action]/{id?}")]
        public IActionResult CountdownAttributeRouting(int id)
        {
            string content = "Counting down: \n";
            for (int i = id; i >= 0; i--)
            {
                content += i + "\n";
            }
            return Content(content);
        }

        //Attribute routing -> overrides all the setting in the method
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
