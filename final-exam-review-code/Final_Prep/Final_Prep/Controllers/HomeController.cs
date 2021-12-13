using Final_Prep.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Prep.Controllers
{
    public class HomeController : Controller
    {
        private AutoContext _context;

        public HomeController(AutoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Manufacturer> manufacturerList = _context.Manufacturers
                .Include(a => a.Cars).ToList();
            return View(manufacturerList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Manufacturer manufacturer)
        {
            
            return View();
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Manufacturer manufacturer)
        {
            if (ModelState.IsValid)
            {

            }
            else
            {
                // adding generic error message
                ModelState.AddModelError("", "There are errors");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
