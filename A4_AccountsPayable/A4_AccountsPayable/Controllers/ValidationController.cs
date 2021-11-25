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
        /// Remote validation to check if there is the same phone number stored 
        /// </summary>
        /// <param name="vendor">Binding a patient model through the Remote validation call due to approach taken (only need the patient's phone number)</param>
        /// <returns>JsonResult indicating if there is another phone number for a patient record that matches the one passed</returns>
        public JsonResult CheckPhoneNumber(Vendor vendor)
        {            
            if (vendor.VendorId == 0)
            {
                string msg = ValidationHelper.PhoneNumberExists(context, vendor.VendorPhone);
                if (string.IsNullOrEmpty(msg))
                {
                    return Json(true);
                }
                else
                {
                    return Json(msg);
                }
            }
            return Json(true);
        }
    }
}
