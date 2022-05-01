using A2_TransactionRecord.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace A2_TransactionRecord.Controllers
{
    // Controller that handles calls for the main page
    public class HomeController : Controller
    {
        #region  Constructor
        public HomeController(TransactionContext context)
        {
            this.context = context;
        }
        #endregion

        #region Properties
        private TransactionContext context { get; set; }
        #endregion
        public IActionResult Index(string order = "ascending")
        {
            if (order == "ascending")
            {
                var transactions = context.TransactionRecordKbaek7943s
                .Include(t => t.TransactionType)
                .Include(t => t.Company)
                .OrderBy(t => t.Company.Name)
                .ToList();
                ViewBag.Flag = "descending";
                return View(transactions);
            }

            else
            {
                var transactions = context.TransactionRecordKbaek7943s
                .Include(t => t.TransactionType)
                .Include(t => t.Company)
                .OrderByDescending(t => t.Company.Name)
                .ToList();
                ViewBag.Flag = "ascending";
                return View(transactions);
            }
        }
    }
}
