using Microsoft.AspNetCore.Http;
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
            string typeChosen = HttpContext.Session.GetString("TypeChosen");

            switch (typeChosen)
            {
                case "Cash In":
                    return RedirectToAction("CashIn");                    

                case "Cash Out":
                    return RedirectToAction("CashOut");                    

                case "Lose":
                    return RedirectToAction("Lose");                    

                case "Win":
                    return RedirectToAction("Win");                    
            }

            var audit = context.Audits
                .Include(a => a.AuditTypes)
                .OrderByDescending(a => a.CreatedDate)
                .ToList();
            return View(audit);
        }

        public IActionResult All()
        {
            var audit = context.Audits
                .Include(a => a.AuditTypes)
                .OrderByDescending(a => a.CreatedDate)
                .ToList();
            return View("Index", audit);
        }

        public IActionResult CashIn(string cashIn)
        {
            HttpContext.Session.SetString("TypeChosen", "Cash In");
            var audit = context.Audits
                            .Include(a => a.AuditTypes)
                            .Where(a => a.AuditTypeId == cashIn)
                            .OrderByDescending(a => a.CreatedDate)
                            .ToList();
            return View("Index", audit);
        }

        public IActionResult CashOut(string cashOut)
        {
            HttpContext.Session.SetString("TypeChosen", "Cash Out");
            var audit = context.Audits
                            .Include(a => a.AuditTypes)
                            .Where(a => a.AuditTypeId == cashOut)
                            .OrderByDescending(a => a.CreatedDate)
                            .ToList();
            return View("Index", audit);
        }

        public IActionResult Lose(string lose)
        {
            HttpContext.Session.SetString("TypeChosen", "Lose");
            var audit = context.Audits
                .Include(a => a.AuditTypes)
                .Where(a => a.AuditTypeId == lose)
                .OrderByDescending(a => a.CreatedDate)
                .ToList();
            return View("Index" ,audit);
        }

        public IActionResult Win(string win)
        {
            HttpContext.Session.SetString("TypeChosen", "Win");
            var audit = context.Audits
                .Include(a => a.AuditTypes)
                .Where(a => a.AuditTypeId == win)
                .OrderByDescending(a => a.CreatedDate)
                .ToList();
            return View("Index", audit);
        }
    }
}
