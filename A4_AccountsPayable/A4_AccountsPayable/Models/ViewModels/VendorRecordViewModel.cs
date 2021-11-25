using A4_AccountsPayable.Models.DBGenerated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A4_AccountsPayable.Models.ViewModels
{
    // vendor record view model with properties to render to VendorRecord view
    public class VendorRecordViewModel
    {
        public Vendor Vendor { get; set; }
        public List<GeneralLedgerAccount> Accounts { get; set; }
        public List<Term> Terms { get; set; }
    }
}
