using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using BPApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BPApp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(BPContext bpContext)
        {
            _bpContext = bpContext;
        }

        public IActionResult Index()
        {
            // setting cookie
            SetWelcomeMessage();

            var bpMeasurements = _bpContext.BPMeasurements
                .Include(msmt => msmt.Positions)
                .OrderByDescending(msmt => msmt.MeasurementDate)
                .ToList();
            return View(bpMeasurements);
        }

        public IActionResult BPInfo()
        {
            // setting cookie
            SetWelcomeMessage();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private void SetWelcomeMessage()
        {
            if (!HttpContext.Request.Cookies.ContainsKey("WelcomeUser"))
            {
                ViewData["WelcomeMessage"] = "Welcome";
                HttpContext.Response.Cookies.Append("WelcomeUser",
                    "Welcome back! You first used this app on" + DateTime.Now);
            }
            else
            {
                ViewData["WelcomeMessage"] = 
                    HttpContext.Request.Cookies["Hey, welcome to the BP App!"];
            }
        }

        private BPContext _bpContext;
    }
}
