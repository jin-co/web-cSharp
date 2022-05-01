using Microsoft.AspNetCore.Mvc;

using HeartRateApp.Models;
using System;
using System.Linq;

namespace HeartRateApp.Controllers
{
    public class HeartRateMeasurementController : Controller
    {
        private HeartRateDbContext _heartRateDbContext;

        public HeartRateMeasurementController(HeartRateDbContext heartRateDbContext)
        {
            _heartRateDbContext = heartRateDbContext;
        }

        [HttpGet()]
        public IActionResult Add()
        {
            this.ViewBag.Action = "Add";

            // second table
            ViewBag.THRGs = _heartRateDbContext.TargetHeartRateGroups.ToList();

            return View("Edit", new HeartRateMeasurement());
        }

        [HttpPost()]
        public IActionResult Add(HeartRateMeasurement heartRateMeasurement)
        {
            if (ModelState.IsValid)
            {
                // since valid hr msmt add to DB and redirect back to all msmt view:
                _heartRateDbContext.HeartRateMeasurements.Add(heartRateMeasurement);
                _heartRateDbContext.SaveChanges();

                // tempData
                TempData["LastActionMessage"] = 
                    $"Measurement {heartRateMeasurement.BPMValue} has been added.";

                return RedirectToAction("Index", "Home");
            }
            else
            {
                this.ViewBag.Action = "Add";
                return View("Edit", heartRateMeasurement);
            }
        }

        [HttpGet()]
        public IActionResult Edit(int id)
        {
            this.ViewBag.Action = "Edit";

            // get model from DB using the ID passed as a param (it came in the URL):
            var hrMsmt = _heartRateDbContext.HeartRateMeasurements.Find(id);

            // second table
            ViewBag.THRGs = _heartRateDbContext.TargetHeartRateGroups.ToList();

            // and return it to the view:
            return View(hrMsmt);
        }

        [HttpPost()]
        public IActionResult Edit(HeartRateMeasurement heartRateMeasurement)
        {
            if (ModelState.IsValid)
            {
                // since valid hr msmt update in the DB and redirect back to all msmt view:
                _heartRateDbContext.HeartRateMeasurements.Update(heartRateMeasurement);
                _heartRateDbContext.SaveChanges();

                // tempData
                TempData["LastActionMessage"] =
                    $"Measurement {heartRateMeasurement.BPMValue} has been updated.";

                return RedirectToAction("Index", "Home");
            }
            else
            {
                this.ViewBag.Action = "Edit";
                return View(heartRateMeasurement);
            }
        }

        [HttpGet()]
        public IActionResult Delete(int id)
        {
            this.ViewBag.Action = "Edit";

            // get model from DB using the ID passed as a param (it came in the URL):
            var hrMsmt = _heartRateDbContext.HeartRateMeasurements.Find(id);

            // and return it to the view:
            return View(hrMsmt);
        }

        //[HttpPost("/[Controller]")]
        [HttpPost("/HeartRateMeasurement/Delete/{id}")]
        public IActionResult DeleteById(int id)
        {
            //if (hrMsmt != null)
            //{
            //    _heartRateDbContext.HeartRateMeasurements.Remove(hrMsmt);
            //    _heartRateDbContext.SaveChanges();
            //}

            var hrMsmt = _heartRateDbContext.HeartRateMeasurements.Find(id);

            if (hrMsmt != null)
            {
                _heartRateDbContext.HeartRateMeasurements.Remove(hrMsmt);
                _heartRateDbContext.SaveChanges();
            }

            TempData["LastActionMessage"] 
                = $"Measurement {hrMsmt.BPMValue} has been deleted. {DateTime.Now}";

            return RedirectToAction("Index", "Home");
        }
    }
}
