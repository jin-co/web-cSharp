using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheatSheetCSharp.Controllers
{
    public class RazorController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Tom";
            ViewBag.Categories = new List<string>
            {
                "C1",
                "C2",
                "C3",
            };
            return View();
        }
    }
}
