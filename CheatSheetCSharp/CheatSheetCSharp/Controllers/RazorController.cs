using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheatSheetCSharp.Controllers
{
    public class RazorController : Controller
    {
        /* View(): Creates a ViewResult object that corresponds to the
         *         name of the current controller and action method
         * View(name): Create a ViewResult object that corresponds to the
         *             current controller and the specified view name
        */
        public IActionResult Index()
        {
            ViewBag.Name = "Tom";
            ViewBag.Categories = new List<string>
            {
                "C1",
                "C2",
                "C3",
            };           
            return View();  // returns Views/Razor/Index.cshtml
            //return View("List");  // returns Views/Product/List.cshtml
        }

        public IActionResult List(string id = "All")
        {
            ViewBag.Category = id;
            return View();    // Views/Product/List.cshtml
        }

        public IActionResult Details(string id)
        {
            ViewBag.ProductSlug = id;
            return View();    // Views/Product/Details.cshtml
        }
    }
}
