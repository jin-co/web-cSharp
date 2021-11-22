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

        public IActionResult Index()
        {
            // vendors
            var vendors = new List<Vendor>();
            vendors = context.Vendors.ToList();

            // vendor names
            List<string> vendorNameList = vendors.Select(s => s.VendorName).Distinct().ToList();

            VendorListViewModel vlvm = new VendorListViewModel()
            {
                Vendors = vendors,
                VendorNameFilter = vendorNameList
            };
            return View(vlvm);
        }

        public IActionResult VendorList(string vendorFilter)
        {
            // vendors
            var vendors = new List<Vendor>();
            vendors = context.Vendors.ToList();            

            switch (vendorFilter)
            {
                case "ae":
                    vendors = vendors
                        .Where(a => a.VendorName.ToLower()[0] <= 'e')
                        .OrderBy(a => a.VendorName).ToList();
                    break;
                case "fk":
                    vendors = vendors
                        .Where(a => a.VendorName.ToLower()[0] > 'f' &&
                        a.VendorName.ToLower()[0] <= 'k')
                        .OrderBy(a => a.VendorName).ToList();
                    break;
                case "lr":
                    vendors = vendors
                        .Where(a => a.VendorName.ToLower()[0] > 'l' &&
                        a.VendorName.ToLower()[0] <= 'r')
                        .OrderBy(a => a.VendorName).ToList();
                    break;
                case "sz":
                    vendors = vendors
                        .Where(a => a.VendorName.ToLower()[0] > 's')
                        .OrderBy(a => a.VendorName).ToList();
                    break;
            }            

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

            return RedirectToAction("Index");
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

            return RedirectToAction("Index");
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
