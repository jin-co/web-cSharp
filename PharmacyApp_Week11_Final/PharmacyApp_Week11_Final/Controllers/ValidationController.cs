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

        public JsonResult CheckPhoneNumber(string phoneNumber)
        {
            string msg = ValidationHelper.PhoneNumberExists(context, phoneNumber);
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
