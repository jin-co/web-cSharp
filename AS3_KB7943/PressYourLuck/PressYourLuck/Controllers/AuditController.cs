using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PressYourLuck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressYourLuck.Controllers
{    
    public class AuditController : Controller
    {
        private readonly PressLuckContext context;

        public AuditController(PressLuckContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var audit = context.Audits
                .Include(a => a.AuditTypes)
                .OrderByDescending(a => a.CreatedDate)
                .ToList();
            return View(audit);
        }

        public IActionResult CashIn(string cashIn)
        {
            var audit = context.Audits
                            .Include(a => a.AuditTypes)
                            .Where(a => a.AuditTypeId == cashIn)
                            .OrderByDescending(a => a.CreatedDate)
                            .ToList();
            return View("Index", audit);
        }

        public IActionResult CashOut(string cashOut)
        {
            var audit = context.Audits
                            .Include(a => a.AuditTypes)
                            .Where(a => a.AuditTypeId == cashOut)
                            .OrderByDescending(a => a.CreatedDate)
                            .ToList();
            return View("Index", audit);
        }

        public IActionResult Lose(string lose)
        {
            var audit = context.Audits
                .Include(a => a.AuditTypes)
                .Where(a => a.AuditTypeId == lose)
                .OrderByDescending(a => a.CreatedDate)
                .ToList();
            return View("Index" ,audit);
        }

        public IActionResult Win(string win)
        {
            var audit = context.Audits
                .Include(a => a.AuditTypes)
                .Where(a => a.AuditTypeId == win)
                .OrderByDescending(a => a.CreatedDate)
                .ToList();
            return View("Index", audit);
        }
    }
}
