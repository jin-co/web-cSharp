using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BPApp.Models;

namespace BPApp.Controllers
{
    public class BPMeasurementController : Controller
    {
        public BPMeasurementController(BPContext bpContext)
        {
            _bpContext = bpContext;
        }

        // Complete the following GET & POST action methods for the Edit request resource..
        [HttpGet()]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost()]
        public IActionResult Edit(BPMeasurement bpMeasurement)
        {
            return null;
        }

        // And similary, add GET & POST action methods for the Add & Delete request resources..

        private BPContext _bpContext;
    }
}
