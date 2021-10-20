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
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var measurement = _bpContext.BPMeasurements.Find(id);

            // second table
            ViewBag.Positions = _bpContext.Positions.ToList();

            return View(measurement);
        }

        [HttpPost()]
        public IActionResult Edit(BPMeasurement bpMeasurement)
        {
            return null;
        }

        // And similary, add GET & POST action methods for the Add & Delete request resources..
        [HttpGet()]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new BPMeasurement());
        }

        [HttpPost()]
        public IActionResult Add(BPMeasurement bpMeasurement)
        {
            return null;
        }

        [HttpGet()]
        public IActionResult Delete(int id)
        {
            var measurement = _bpContext.BPMeasurements.Find(id);

            // second table
            ViewBag.Positions = _bpContext.Positions.ToList();

            return View(measurement);
        }

        [HttpPost()]
        public IActionResult Delete(BPMeasurement bpMeasurement)
        {
            return null;
        }
        private BPContext _bpContext;
    }
}
