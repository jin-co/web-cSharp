using L1_Bmi_Empty.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace L1_Bmi_Empty.Controllers
{
    public class BmiController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Bmi = 0.0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(BmiModel bmiModel)
        {
            ViewBag.Bmi = bmiModel.CalculateBMI();
            return View(bmiModel);
        }
    }
}
