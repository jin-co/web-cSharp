using A4_AccountsPayable.Models.DBGenerated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A4_AccountsPayable.Models.ViewModels
{
    // vendor list view model with properties to render to Index view
    public class VendorListViewModel
    {
        public List<Vendor> Vendors { get; set; }
        public string SelectedVendorFilter { get; set; }

        /// <summary>
        /// Returns 'bg-dark' to the current page a user is in
        /// </summary>
        /// <param name="filterName"></param>
        /// <returns></returns>
        public string GetActiveVendorFilter(string filterName)
        {
            return SelectedVendorFilter == filterName ? "bg-dark" : "";
        }
    }
}
