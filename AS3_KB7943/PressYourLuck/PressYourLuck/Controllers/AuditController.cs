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
            HttpContext.Session.SetString("TypeChosen", "All");
            var audit = context.Audits
                .Include(a => a.AuditTypes)
                .OrderByDescending(a => a.CreatedDate)
                .ToList();
            return View("Index", audit);
        }

        public IActionResult CashIn(string cashIn)
        {
            if (cashIn != null)
            {
                HttpContext.Session.SetString("TypeChosen", cashIn);
            }
            string typeChosen = HttpContext.Session.GetString("TypeChosen");

            var audit = context.Audits
                            .Include(a => a.AuditTypes)
                            .Where(a => a.AuditTypeId == typeChosen)
                            .OrderByDescending(a => a.CreatedDate)
                            .ToList();
            return View("Index", audit);
        }

        public IActionResult CashOut(string cashOut)
        {
            if (cashOut != null)
            {
                HttpContext.Session.SetString("TypeChosen", cashOut);
            }
            string typeChosen = HttpContext.Session.GetString("TypeChosen");
            
            var audit = context.Audits
                            .Include(a => a.AuditTypes)
                            .Where(a => a.AuditTypeId == typeChosen)
                            .OrderByDescending(a => a.CreatedDate)
                            .ToList();
            return View("Index", audit);
        }

        public IActionResult Lose(string lose)
        {
            if (lose != null)
            {
                HttpContext.Session.SetString("TypeChosen", lose);
            }
            string typeChosen = HttpContext.Session.GetString("TypeChosen");
            
            var audit = context.Audits
                .Include(a => a.AuditTypes)
                .Where(a => a.AuditTypeId == typeChosen)
                .OrderByDescending(a => a.CreatedDate)
                .ToList();
            return View("Index" ,audit);
        }

        public IActionResult Win(string win)
        {
            if (win != null)
            {
                HttpContext.Session.SetString("TypeChosen", win);
            }
            string typeChosen = HttpContext.Session.GetString("TypeChosen");
            
            var audit = context.Audits
                .Include(a => a.AuditTypes)
                .Where(a => a.AuditTypeId == typeChosen)
                .OrderByDescending(a => a.CreatedDate)
                .ToList();
            return View("Index", audit);
        }
    }
}
