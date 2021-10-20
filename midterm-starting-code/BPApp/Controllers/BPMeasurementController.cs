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
            if (ModelState.IsValid)
            {
                // since valid hr msmt update in the DB and redirect back to all msmt view:
                _bpContext.BPMeasurements.Update(bpMeasurement);
                _bpContext.SaveChanges();

                // tempData
                TempData["LastActionMessage"] =
                    $"Measurement {bpMeasurement.Systolic} " +
                    $"({bpMeasurement.MeasurementDate})" +
                    $"has been updated.";

                return RedirectToAction("Index", "Home");
            }
            else
            {
                this.ViewBag.Action = "Edit";
                return View(bpMeasurement);
            }
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
            if (ModelState.IsValid)
            {
                // since valid hr msmt add to DB and redirect back to all msmt view:
                _bpContext.BPMeasurements.Add(bpMeasurement);
                _bpContext.SaveChanges();

                // tempData
                TempData["LastActionMessage"] =
                    $"Measurement {bpMeasurement} has been added.";

                return RedirectToAction("Index", "Home");
            }
            else
            {
                this.ViewBag.Action = "Add";
                return View("Edit", bpMeasurement);
            }
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
        public IActionResult DeleteById(int id)
        {
            var measurement = _bpContext.BPMeasurements.Find(id);

            if (measurement != null)
            {
                _bpContext.BPMeasurements.Remove(measurement);
                _bpContext.SaveChanges();
            }

            TempData["LastActionMessage"]
                = $"Measurement {measurement.Systolic} " +
                $"({measurement.MeasurementDate})" +
                $"has been deleted. {DateTime.Now}";

            return RedirectToAction("Index", "Home");
        }
        private BPContext _bpContext;
    }
}
