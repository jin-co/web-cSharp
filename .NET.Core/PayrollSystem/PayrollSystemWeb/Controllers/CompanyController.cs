using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollSystem.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            // validate inbound
            // interect with business layer
            // choose the view
            return View();
        }

        [HttpPost]
        public IActionResult SaveDetail(string id, string name, string streetAdress)
        {
            // validate inbound
            // interect with business layer
            // choose the view
            return View("Index");
        }
    }

}
