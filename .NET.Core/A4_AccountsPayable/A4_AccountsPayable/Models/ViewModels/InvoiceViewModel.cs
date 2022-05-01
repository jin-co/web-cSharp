using A4_AccountsPayable.Models.DBGenerated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A4_AccountsPayable.Models.ViewModels
{
    // invoice view model with properties to render to Invoice view
    public class InvoiceViewModel
    {
        public Vendor Vendor { get; set; }
        public GeneralLedgerAccount Account { get; set; }
        public List<Invoice> Invoices { get; set; }
        public List<InvoiceLineItem> InvoiceLineItems { get; set; }
        public Invoice SelectedInvoice { get; internal set; }
        public int SelectedInvoiceID { get; internal set; }
        public decimal LineItemAmountTotal { get; set; }
    }
}
