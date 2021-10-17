using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheatSheetCSharp.Controllers
{
    public class RouteController : Controller
    {
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

    }
}
