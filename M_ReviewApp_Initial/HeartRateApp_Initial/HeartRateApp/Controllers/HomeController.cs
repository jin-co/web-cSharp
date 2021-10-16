﻿using HeartRateApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using HeartRateApp.Models;

namespace HeartRateApp.Controllers
{
    public class HomeController : Controller
    {
        private HeartRateDbContext _heartRateDbContext;

        // This context is passed to our controller constructor when it's
        // created by the DI container:
        public HomeController(HeartRateDbContext heartRateDbContext)
        {
            // we simply store it in a private data field for use in all action methods:
            _heartRateDbContext = heartRateDbContext;
        }

        public IActionResult Index()
        {
            // We get all HR msmts ordered by data desc (i.e. most recent at the top):
            var heartRateMeasurments = _heartRateDbContext.HeartRateMeasurements
                .OrderByDescending(msmt => msmt.MeasurementDate)
                .ToList();
            
            return View(heartRateMeasurments);
        }

        public IActionResult HeartRateInfo()
        {
            return View();
        }
    }
}
