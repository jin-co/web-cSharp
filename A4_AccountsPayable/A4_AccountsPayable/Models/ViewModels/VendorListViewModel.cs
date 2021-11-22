using A4_AccountsPayable.Models.DBGenerated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A4_AccountsPayable.Models.ViewModels
{
    public class VendorListViewModel
    {
        public List<Vendor> Vendors { get; set; }
        public List<string> VendorNameFilter { get; set; }
    }
}
