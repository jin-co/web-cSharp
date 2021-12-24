using CheatSheetCSharp.Areas.Validation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CheatSheetCSharp.Areas.Validation.Controllers
{
    [Area("Validation")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Result = "Success";
            }
            else
            {
                ViewBag.Result = "Failed";
            }

            return View(userModel);
        }
    }
}
