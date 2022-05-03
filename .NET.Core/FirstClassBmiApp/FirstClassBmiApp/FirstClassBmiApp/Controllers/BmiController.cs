using FirstClassBmiApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstClassBmiApp.Controllers
{
    public class BmiController : Controller
    {
        // This is the initial page that the application loads up to as configured in the endpoint found
        // in the "Startup.cs" class of the project. This is a simple GET request of the "Index" view page
        // found in the "Views -> Bmi" subfolder of the project. It simply returns the view page without altering
        // anything asides from setting the Bmi variable inside the viewbag to 0.0.
        [HttpGet]
        public IActionResult Index()
        {
            // This is a dynamic variable used to store the BMI value of 0.0 (it is retrievable in the "Index" view)
            ViewBag.Bmi = 0.0;

            // Returns an empty view
            return View();
        }

        // This method is called as a result from clicking the "Calculate" button on the "Index" view page, causing a 
        // POST request back to this BmiController with a completed and filled BmiModel called "bmiModel". The method
        // below calls the "CalculateBMI()" method found in the BmiModel class under "Models" and returns the Bmi value
        // stored inside the ViewBag.Bmi variable.
        [HttpPost]
        public IActionResult Index(BmiModel bmiModel)
        {
            // The same dynamic variable used to store the calculated BMI value from (Weight / (Height * Height))
            ViewBag.Bmi = bmiModel.CalculateBMI();

            // Returns the view with a completed bmiModel object
            return View(bmiModel);
        }
    }
}
