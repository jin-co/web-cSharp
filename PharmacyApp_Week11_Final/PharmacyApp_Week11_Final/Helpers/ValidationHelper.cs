using PharmacyApp_Week11_Final.Models.DBGenerated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PharmacyApp_Week11_Final.Helpers
{
    public static class ValidationHelper
    {
        public static string PhoneNumberExists(PatientContext context, string phoneNumber)
        {
            string msg = "";
            if (!string.IsNullOrEmpty(phoneNumber))
            {
                var patient = context.Patients.FirstOrDefault(
                    c => Regex.Replace(c.PatientPhone, "[^0-9]", "") == Regex.Replace(phoneNumber, "[^0-9]", ""));
                
                if (patient != null)
                    msg = $"Phone number {phoneNumber} is already in use.";
            }
            return msg;
        }
    }
}
