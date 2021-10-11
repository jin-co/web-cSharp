using A2_TransactionRecord.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace A2_TransactionRecord.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(TransactionContext context)
        {
            this.context = context;
        }

        private TransactionContext context { get; set; }

        public IActionResult Index()
        {
            var transactions = context.TransactionRecordKbaek7943s
                .OrderBy(t => t.CompanyName)
                .ToList();
            return View(transactions);
        }
    }
}
