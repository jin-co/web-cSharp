using CheatSheetCSharp.Areas.FutureValue.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheatSheetCSharp.Areas.FutureValue.Controllers

{
    [Area("FutureValue")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FV = 0;
            ViewBag.SelectList = new List<string>
            {
                "Guitars",
                "Basses",
                "Drums"
            };
            return View();
        } 
        
        [HttpPost]
        public IActionResult Index(FutureValueModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.GetFutureValue();
            }
            else
            {
                ViewBag.FV = 0;
            }
            return View(model);
        }
    }
}
