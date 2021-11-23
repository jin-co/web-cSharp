using A4_AccountsPayable.Models;
using A4_AccountsPayable.Models.DBGenerated;
using A4_AccountsPayable.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
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
            if (Request.Cookies["activePage"] == null)
            {
                Response.Cookies.Append("activePage", vendorFilter);
            }
            

            switch (vendorFilter)
            {
                case "ae":
                    vendors = vendors
                        .Where(a => a.VendorName.ToLower()[0] <= 'e')
                        .OrderBy(a => a.VendorName).ToList();
                    TempData["activePage"] = "ae";
                    break;
                case "fk":
                    vendors = vendors
                        .Where(a => a.VendorName.ToLower()[0] > 'f' &&
                        a.VendorName.ToLower()[0] <= 'k')
                        .OrderBy(a => a.VendorName).ToList();
                    TempData["activePage"] = "fk";
                    break;
                case "lr":
                    vendors = vendors
                        .Where(a => a.VendorName.ToLower()[0] > 'l' &&
                        a.VendorName.ToLower()[0] <= 'r')
                        .OrderBy(a => a.VendorName).ToList();
                    TempData["activePage"] = "lr";
                    break;
                case "sz":
                    vendors = vendors
                        .Where(a => a.VendorName.ToLower()[0] > 's')
                        .OrderBy(a => a.VendorName).ToList();
                    TempData["activePage"] = "sz";
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

        public IActionResult Invoice()
        {
            return View();
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
