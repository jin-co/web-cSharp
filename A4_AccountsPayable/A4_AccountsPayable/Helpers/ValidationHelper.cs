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
        public static string PhoneNumberExists(apContext context, Vendor vendor)
        {
            List<string> phones = context.Vendors.Select(a => a.VendorPhone).ToList();
            List<int> vendorIds = context.Vendors.Select(a => a.VendorId).ToList();
            Vendor storedPhone = context.Vendors.Find(vendor.VendorId);
            string msg = "";
            if (vendorIds.Contains(vendor.VendorId))
            {
                foreach (var i in vendorIds)
                {
                    // allows a user can use the same old phone when editing
                    if (i == vendor.VendorId && storedPhone.VendorPhone == vendor.VendorPhone)
                    {
                        msg = "";
                        return msg;
                    }
                }

                if (phones.Contains(vendor.VendorPhone))
                {
                    msg = $"Phone number {vendor.VendorPhone} is already in use.";
                }
            }
            else
            {
                if (phones.Contains(vendor.VendorPhone))
                {
                    msg = $"Phone number {vendor.VendorPhone} is already in use.";
                }
            }
            
            return msg;
        }
    }
}
