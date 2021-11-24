using A4_AccountsPayable.Models.DBGenerated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A4_AccountsPayable.Models.ViewModels
{
    public class InvoiceViewModel
    {
        public Vendor Vendor { get; set; }
        public List<Invoice> Invoices { get; set; }

        public Invoice Invoice { get; set; }
        public decimal LineItemAmountTotal { get; set; }
        public List<InvoiceLineItem> InvoiceLineItems { get; set; }

        public InvoiceLineItem InvoiceLineItem { get; set; }

        public List<GeneralLedgerAccount> Accounts { get; set; }
        public List<Term> Terms { get; set; }

    }
}
