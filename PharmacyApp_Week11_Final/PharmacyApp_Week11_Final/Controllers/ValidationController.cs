using Microsoft.AspNetCore.Mvc;
using PharmacyApp_Week11_Final.Helpers;
using PharmacyApp_Week11_Final.Models.DBGenerated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyApp_Week11_Final.Controllers
{
    public class ValidationController : Controller
    {
        private PatientContext context;
        public ValidationController(PatientContext patientDBContext)
        {
            context = patientDBContext;
        }

        /// <summary>
        /// Remote validation logic to check and see if another patient has the same phone number stored in their record
        /// </summary>
        /// <param name="patient">Binding a patient model through the Remote validation call due to approach taken (only need the patient's phone number)</param>
        /// <returns>JsonResult indicating if there is another phone number for a patient record that matches the one passed</returns>
        public JsonResult CheckPhoneNumber(Patient patient)
        {
            // Call the validation helper class and execute its static method PhoneNumberExists to see there is a phone number match or not.
            string msg = ValidationHelper.PhoneNumberExists(context, patient.PatientPhone);
            
            // If there is no message returned from the method above, the phone number is unique and there is no validation errors, otherwise, return the error
            // message returned from the method call above.
            if (string.IsNullOrEmpty(msg))
            {
                TempData["okPhoneNumber"] = true;
                return Json(true);
            }
            else
            {
                return Json(msg);
            }  
        }
    }
}
