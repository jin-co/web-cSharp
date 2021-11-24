using A4_AccountsPayable.Helpers;
using A4_AccountsPayable.Models.DBGenerated;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A4_AccountsPayable.Controllers
{
    public class ValidationController : Controller
    {
        private readonly apContext context;

        public ValidationController(apContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Remote validation logic to check and see if another patient has the same phone number stored in their record
        /// </summary>
        /// <param name="vendor">Binding a patient model through the Remote validation call due to approach taken (only need the patient's phone number)</param>
        /// <returns>JsonResult indicating if there is another phone number for a patient record that matches the one passed</returns>
        public JsonResult CheckPhoneNumber(Vendor vendor)
        {
            // Call the validation helper class and execute its static method PhoneNumberExists to see there is a phone number match or not.
            string msg = ValidationHelper.PhoneNumberExists(context, vendor.VendorPhone);

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
