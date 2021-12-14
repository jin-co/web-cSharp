using Final_Prep.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Prep.Controllers
{
    public class PartController : Controller
    {
        private AutoContext _context;

        public PartController(AutoContext context)
        {
            _context = context;
        }

        public IActionResult ListByCar(int carId)
        {
            // this will call method below
            return Index(carId);
        }

        public IActionResult Index(int carId)
        {
            List<Part> parts = _context.Parts.ToList();

            if (carId != 0)
            {
                parts = parts.Where(a => a.CarId == carId).ToList();
            }

            return View("Index", parts);
        }
    }
}
