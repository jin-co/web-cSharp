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
        public IActionResult Index()
        {
            var transactions = context.TransactionRecordKbaek7943s
                .Include(t => t.TrasactionType)
                .OrderBy(t => t.TransactionTypeId)
                .ToList();
            return View(transactions);
        }
    }
}
