﻿using A4_AccountsPayable.Models;
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
            
            var options = new CookieOptions { Expires = DateTime.Now.AddDays(30) };
            if (vendorFilter != null)
            {
                Response.Cookies.Append("activePage", vendorFilter, options);
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
            //ModelState.AddModelError("", "Error");
            ViewBag.ActionType = actionType;
            
            // edit
            var vendor = context.Vendors.Find(id);

            VendorRecordViewModel vrvm = new VendorRecordViewModel()
            {
                Vendor = vendor,
                Accounts = context.GeneralLedgerAccounts.ToList(),
                Terms = context.Terms.ToList()
            };

            return View(vrvm);
        }

        [HttpPost]
        public IActionResult VendorRecord(Vendor vendor)
        {
            // test
            




            //test


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
                return Redirect($"/?vendorFilter={Request.Cookies["activePage"]}");
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
            var vendor = context.Vendors.Find(vendorId);
            var invoice = context.Invoices
                .Where(a => a.VendorId == vendorId).ToList();

            decimal total = context.Invoices
                .Where(a => a.VendorId == vendorId).Sum(a => a.InvoiceTotal);

            if (invoiceId != 0)
            {
                invoice = invoice.Where(a => a.InvoiceId == invoiceId).ToList();
                total = context.Invoices
                    .Where(a => a.VendorId == vendorId && 
                    a.InvoiceId == invoiceId).Sum(a => a.InvoiceTotal);
            }
            
            // active page
            ViewBag.Page = Request.Cookies["activePage"];

            InvoiceViewModel ivm = new InvoiceViewModel()
            {
                Vendor = vendor,
                Invoice = invoice,
                CreditTotal = total,
                Accounts = context.GeneralLedgerAccounts.ToList(),
                Terms = context.Terms.ToList()
            };
            return View(ivm);
        }

        public IActionResult AddNewInvoiceLineItem()
        {
            InvoiceViewModel ivm = new InvoiceViewModel()
            {
   
                Accounts = context.GeneralLedgerAccounts.ToList(),
                Terms = context.Terms.ToList()
            };
            return View(ivm);
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
