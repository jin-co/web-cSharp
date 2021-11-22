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


        public IActionResult VendorList()
        {
            var vendors = new List<Vendor>();
            vendors = context.Vendors.ToList();
            
            return View(vendors);
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
