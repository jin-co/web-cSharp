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
    }
}
