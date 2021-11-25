using A4_AccountsPayable.Models.DBGenerated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A4_AccountsPayable.Helpers
{
    public class ValidationHelper
    {
        /// <summary>
        /// Verifies in the database that there is no other patient with the provided phone number
        /// </summary>
        /// <param name="context">Binds the application database context</param>
        /// <param name="patientPhone">Binds the passed phone number to validate for uniqueness</param>
        /// <returns>A string indicating whether there was a match found or not</returns>
        public static string PhoneNumberExists(apContext context, string vendorPhone)
        {
            List<string> phones = context.Vendors.Select(a => a.VendorPhone).ToList();
            string msg = "";
            foreach (var i in phones)
            {
                if (i == vendorPhone)
                {
                    msg = $"Phone number {vendorPhone} is already in use.";
                    return msg;
                }
            }
            return "";
        }
    }
}
