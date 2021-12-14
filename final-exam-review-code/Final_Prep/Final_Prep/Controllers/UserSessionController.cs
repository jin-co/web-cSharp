using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Prep.Controllers
{
    public class UserSessionController : Controller
    {
        public IActionResult Index()
        {
            List<string> actionLog = new List<string>();

            if (HttpContext.Session.Keys.Contains("auditLog"))
            {
                // action list
                string auditLog = HttpContext.Session.GetString("auditLog");

                string[] logs = auditLog.Split('|');

                foreach (var i in logs)
                {
                    actionLog.Add(i);
                }
            }
            return View(actionLog);
        }
    }
}
