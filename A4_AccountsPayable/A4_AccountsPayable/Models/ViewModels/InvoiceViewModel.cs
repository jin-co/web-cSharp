using A4_AccountsPayable.Models.DBGenerated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A4_AccountsPayable.Models.ViewModels
{
    public class InvoiceViewModel
    {
        //public Vendor Vendor { get; set; }
        //public List<Invoice> Invoices { get; set; }

        //public Invoice Invoice { get; set; }
        public decimal LineItemAmountTotal { get; set; }
        //public List<InvoiceLineItem> InvoiceLineItems { get; set; }

        //public InvoiceLineItem InvoiceLineItem { get; set; }

        public List<GeneralLedgerAccount> Accounts { get; set; }
        public List<Term> Terms { get; set; }

        public Vendor Vendor { get; set; }
        public Term Term { get; set; }

        public List<Invoice> Invoices { get; set; }
        public List<InvoiceLineItem> InvoiceLineItems { get; set; }
        public int SelectedInvoiceID { get; internal set; }
        public Invoice SelectedInvoice { get; internal set; }
    }
}
