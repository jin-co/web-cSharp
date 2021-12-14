using Final_Prep.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Prep.Controllers
{
    public class HomeController : Controller
    {
        private AutoContext _context;

        public HomeController(AutoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Manufacturer> manufacturerList = _context.Manufacturers
                .Include(a => a.Cars).ToList();
            return View(manufacturerList);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Add()
        {
            string actionName = GetControllerActionMethodTypeName();
            string auditLog = GetAuditLogSessionVariable();
            AddToAuditLogSessionVariable(auditLog, actionName);
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(Manufacturer manufacturer)
        {
            string actionName = GetControllerActionMethodTypeName();
            string auditLog = GetAuditLogSessionVariable();
            AddToAuditLogSessionVariable(auditLog, actionName);
            return View();
        }

        [HttpGet]
        public IActionResult Edit()
        {
            string actionName = GetControllerActionMethodTypeName();
            string auditLog = GetAuditLogSessionVariable();
            AddToAuditLogSessionVariable(auditLog, actionName);
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Manufacturer manufacturer)
        {
            string actionName = GetControllerActionMethodTypeName();
            string auditLog = GetAuditLogSessionVariable();
            AddToAuditLogSessionVariable(auditLog, actionName);
            if (ModelState.IsValid)
            {

            }
            else
            {
                // adding generic error message
                ModelState.AddModelError("", "There are errors");
            }
            return View();
        }

        private string GetControllerActionMethodTypeName()
        {
            string controllerName = ControllerContext.RouteData.Values["controller"].ToString();
            string actionName = ControllerContext.RouteData.Values["action"].ToString();
            string methodName = ControllerContext.HttpContext.Request.Method;

            return $"Controller: {controllerName} / Action: {actionName} / Method type: {methodName}";
        }

        private string GetAuditLogSessionVariable()
        {
            if (!HttpContext.Session.Keys.Contains("auditLog"))
            {
                HttpContext.Session.SetString("auditLog", "");          
            }

            return HttpContext.Session.GetString("auditLog");
        }

        private void AddToAuditLogSessionVariable(string auditLog, string actionName)
        {
            HttpContext.Session.SetString("auditLog", auditLog + "|" + actionName);
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
