﻿using Final_Prep.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Prep.Controllers
{
    public class CarController : Controller
    {
        private AutoContext _context;

        public CarController(AutoContext context)
        {
            _context = context;
        }

        public IActionResult Index(int manufacturerId)
        {
            List<Car> cars = _context.Cars
                .Include(a => a.Parts)
                .Include(a => a.Manufacturer)
                .ToList();
            if (manufacturerId != 0)
            {
                cars = cars
                    .Where(a => a.ManufacturerId == manufacturerId)
                    .ToList();
            }
            return View("Index", cars);
        }
    }
}
