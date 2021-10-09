﻿using A1_TransactionRecord.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace A1_TransactionRecord.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(TransactionContext context) 
        {
            this.context = context;
        }

        private TransactionContext context { get; set; }

        public IActionResult Index(string order)
        {
            if (order == "ascending")
            {
                var transactions = context.TransactionRecordKbaek7943s
                .Include(t => t.TrasactionType)
                .OrderBy(t => t.CompanyName)
                .ToList();
                ViewBag.Flag = "descending";
                return View(transactions);
            }

            else
            {
                var transactions = context.TransactionRecordKbaek7943s
                .Include(t => t.TrasactionType)
                .OrderByDescending(t => t.CompanyName)
                .ToList();
                ViewBag.Flag = "ascending";
                return View(transactions);
            }
        }
    }
}
