using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace HeartRateApp.Controllers
{
    public class SessionTextController1 : Controller
    {
        public IActionResult Index()
        {
            int num = (int)HttpContext.Session.GetInt32("num");
            num += 1;
            HttpContext.Session.SetInt32("num", num);

            return View();
        }
    }
}
