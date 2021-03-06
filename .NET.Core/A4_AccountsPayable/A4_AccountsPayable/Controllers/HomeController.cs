using A4_AccountsPayable.Helpers;
using A4_AccountsPayable.Models;
using A4_AccountsPayable.Models.DBGenerated;
using A4_AccountsPayable.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace A4_AccountsPayable.Controllers
{
    public class HomeController : Controller
    {
        private readonly apContext context;

        public HomeController(apContext context)
        {
            this.context = context;
        }

        public IActionResult Index(string vendorFilter)
        {
            var vendors = new List<Vendor>();
            vendors = context.Vendors.ToList();

            // cookie
            if (vendorFilter != null)
            {
                HttpContext.Session.SetString("activePage", vendorFilter);
            }

            switch (vendorFilter)
            {
                case "A-E":
                    vendors = vendors
                        .Where(a => a.VendorName.ToLower()[0] <= 'e')
                        .OrderBy(a => a.VendorName).ToList();
                    TempData["activePage"] = "A-E";
                    break;
                case "F-K":
                    vendors = vendors
                        .Where(a => a.VendorName.ToLower()[0] > 'e' &&
                        a.VendorName.ToLower()[0] <= 'k')
                        .OrderBy(a => a.VendorName).ToList();
                    TempData["activePage"] = "F-K";
                    break;
                case "L-R":
                    vendors = vendors
                        .Where(a => a.VendorName.ToLower()[0] > 'k' &&
                        a.VendorName.ToLower()[0] <= 'r')
                        .OrderBy(a => a.VendorName).ToList();
                    TempData["activePage"] = "L-R";
                    break;
                case "S-Z":
                    vendors = vendors
                        .Where(a => a.VendorName.ToLower()[0] > 'r')
                        .OrderBy(a => a.VendorName).ToList();
                    TempData["activePage"] = "S-Z";
                    break;
                default:
                    vendors = vendors.OrderBy(a => a.VendorName).ToList();
                    break;
            }

            // soft delete filter
            vendors = vendors.Where(a => a.IsDeleted == false).ToList();

            VendorListViewModel vlvm = new VendorListViewModel()
            {
                Vendors = vendors,
                SelectedVendorFilter = vendorFilter
            };
            return View("Index", vlvm);
        }

        public IActionResult SoftDelete(int id)
        {
            var vendor = context.Vendors.Find(id);

            if (vendor != null)
            {
                vendor.IsDeleted = true;
                context.Update(vendor);
                context.SaveChanges();
            }

            TempData["DeletedVendorName"] = vendor.VendorName;
            TempData["DeletedVendorId"] = vendor.VendorId;

            return Redirect($"/Home/?vendorFilter={TempData["activePage"]}");
        }

        public IActionResult UnDoSoftDelete(int id)
        {
            var vendor = context.Vendors.Find(id);

            if (vendor != null)
            {
                vendor.IsDeleted = false;
                context.Update(vendor);
                context.SaveChanges();
            }

            return Redirect($"/Home/?vendorFilter={TempData["activePage"]}");
        }
        
        // edit and add
        public IActionResult VendorRecord(int id, string actionType)
        {
            ViewBag.ActionType = actionType;
            Vendor vendor = null;

            if (actionType == "Add")
            {
                vendor = new Vendor();
            }
            else if (actionType == "Edit")
            {
                vendor = context.Vendors.Find(id);
            }

            VendorRecordViewModel vrvm = new VendorRecordViewModel()
            {
                Vendor = vendor,
                Accounts = context.GeneralLedgerAccounts.ToList(),
                Terms = context.Terms.ToList()
            };

            return View(vrvm);
        }

        [HttpPost]
        public IActionResult VendorRecord(Vendor vendor, string actionType)
        {
            ViewBag.ActionType = actionType;

            if (ModelState.IsValid)
            {
                //add
                if (vendor.VendorId == 0)
                {
                    context.Vendors.Add(vendor);
                }
                else
                {
                    context.Update(vendor);
                }
                context.SaveChanges();
                return Redirect($"/?vendorFilter={HttpContext.Session.GetString("activePage")}");
            }
            else
            {
                ModelState.AddModelError("", "There are errors");
                VendorRecordViewModel vrvm = new VendorRecordViewModel()
                {
                    Vendor = vendor,
                    Accounts = context.GeneralLedgerAccounts.ToList(),
                    Terms = context.Terms.ToList()
                };

                return View(vrvm);
            }            
        }

        public IActionResult Invoice(int vendorId, int invoiceId)
        {                                 
            decimal total = context.InvoiceLineItems
                .Where(a => a.InvoiceId == invoiceId).Sum(a => a.LineItemAmount);

            var vendors = context.Vendors.Include(i => i.Invoices).ThenInclude(ti => ti.InvoiceLineItems);
            var vendorRecord = vendors.Where(w => w.VendorId == vendorId).FirstOrDefault();
            var term = context.Terms.Find(vendorRecord.DefaultTermsId);
            var ledger = context.GeneralLedgerAccounts.Find(vendorRecord.DefaultAccountNumber);
            var invoices = vendorRecord.Invoices.ToList();

            var selectedInvoiceID = 0;
            Invoice selectedInvoice = null;
            List<InvoiceLineItem> invoiceLineItems = new List<InvoiceLineItem>();

            if (invoiceId != 0)
            {
                selectedInvoiceID = invoiceId;
                selectedInvoice = invoices.Where(w => w.InvoiceId == selectedInvoiceID).FirstOrDefault();
                invoiceLineItems = selectedInvoice.InvoiceLineItems.ToList();
            }
            else if (invoices.Count() > 0)
            {
                selectedInvoiceID = invoices.First().InvoiceId;
                selectedInvoice = invoices.First();
                invoiceLineItems = context.InvoiceLineItems.Where(a => a.InvoiceId == selectedInvoiceID).ToList();
            }

            if (invoiceId != 0)
            {
                invoices = invoices.Where(a => a.InvoiceId == invoiceId).ToList();
                total = context.Invoices
                    .Where(a => a.VendorId == vendorId &&
                    a.InvoiceId == invoiceId).Sum(a => a.InvoiceTotal);
            }

            // active page
            ViewBag.Page = Request.Cookies["activePage"];

            InvoiceViewModel ivm = new InvoiceViewModel()
            {
                Vendor = vendorRecord,
                Invoices = invoices,
                InvoiceLineItems = invoiceLineItems,
                LineItemAmountTotal = total,
                Account = ledger,
                SelectedInvoiceID = selectedInvoiceID,
                SelectedInvoice = selectedInvoice         
            };
            return View(ivm);
        }

        public IActionResult AddNewInvoiceLineItem(
            int vendorId, int invoiceId, int accountNumber, decimal amount, string description)
        {
            var lastSequence = context.InvoiceLineItems
                .Where(a => a.InvoiceId == invoiceId).Max(a => a.InvoiceSequence);
            InvoiceLineItem invoiceLineItem = new InvoiceLineItem()
            {
                InvoiceId = invoiceId,
                InvoiceSequence = lastSequence += 1,
                AccountNumber = accountNumber,
                LineItemAmount = amount,
                LineItemDescription = description
            };
            context.InvoiceLineItems.Add(invoiceLineItem);

            var invoice = context.Invoices.Find(invoiceId);
            invoice.InvoiceTotal += amount;
            context.Invoices.Update(invoice);
            context.SaveChanges();

            return RedirectToAction("Invoice", new { vendorId, invoiceId });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
