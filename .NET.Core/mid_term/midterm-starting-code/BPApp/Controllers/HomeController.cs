using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using BPApp.Models;

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
            var bpMeasurements = _bpContext.BPMeasurements.OrderByDescending(msmt => msmt.MeasurementDate).ToList();
            return View(bpMeasurements);
        }

        public IActionResult BPInfo()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private BPContext _bpContext;
    }
}
