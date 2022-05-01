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
        /// <summary>
        /// Verifies in the database that there is no other patient with the provided phone number
        /// </summary>
        /// <param name="context">Binds the application database context</param>
        /// <param name="patientPhone">Binds the passed phone number to validate for uniqueness</param>
        /// <returns>A string indicating whether there was a match found or not</returns>
        public static string PhoneNumberExists(PatientContext context, string patientPhone)
        {
            string msg = "";
            
            // Checks to see that the phone number provided contains a value.
            if (!string.IsNullOrEmpty(patientPhone))
            {
                // Strip out all of the digits out of the store phone number in order to simplify the comparison below.
                string numericPhoneNumber = new String(patientPhone.Where(Char.IsDigit).ToArray());

                bool match = false;

                // Iterate through all the patient records to try and identify a matching phone number
                foreach (var patient in context.Patients.ToList())
                {
                    // Have to make sure that the patient's phone number has a value, otherwise an error will occur
                    if (patient.PatientPhone != null)
                    {
                        // Strip out all of the digits to compare with passed phone number
                        string patientPhoneNumber = new String(patient.PatientPhone.Where(Char.IsDigit).ToArray());

                        // If a match is found, report it, otherwise, keep looping until all records have been searched through.
                        match = patientPhoneNumber == numericPhoneNumber;

                        if (match)
                        {
                            break;
                        }
                    }
                }

                if (match)
                    msg = $"Phone number {patientPhone} is already in use.";
            }
            return msg;
        }
    }
}
