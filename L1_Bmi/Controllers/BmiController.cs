using L1_Bmi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace L1_Bmi.Controllers
{
    public class BmiController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.bmi = 0.00;
            return View();
        }

        [HttpPost]
        public IActionResult Index(BmiModel bmiModel)
        {
            ViewBag.bmi = bmiModel.CalculateBMI();
            return View(bmiModel);
        }
    }
}
