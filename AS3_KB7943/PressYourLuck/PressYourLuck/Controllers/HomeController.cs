using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PressYourLuck.Models;
using PressYourLuck.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PressYourLuck.Controllers
{
    public class HomeController : Controller
    {
        private readonly PressLuckContext context;

        public HomeController(PressLuckContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            if (Request.Cookies["name"] != null)
            {
                ViewBag.Name = Request.Cookies["name"];
                ViewBag.Coin = Request.Cookies["coins"];
                return View();
            }
            else
            {
                return Redirect("Player/Index");
            }
        }

        [HttpPost]
        public IActionResult Index(CurrentGameModel currenGame)
        {
            HttpContext.Session.SetString("bet", currenGame.CurrentBettingAmount.ToString());            
            ViewBag.Name = Request.Cookies["name"];
            ViewBag.Coin = Request.Cookies["coins"];

            double bet = double.Parse(HttpContext.Session.GetString("bet"));
            double coin = double.Parse(Request.Cookies["coins"]);
            double cal = coin - bet;

            // total coin 
            Response.Cookies.Append("coins", cal.ToString());

            return Redirect("Game/Index");
        }

        public IActionResult ClearUser()
        {                        
            double coin = double.Parse(Request.Cookies["coins"]);
            if (coin > 0)
            {
                //TempMessage
                TempData["CashOut"] = $"You cashed out for ${coin}";
            }

            //save data
            var cashOut = new Audit(
                Request.Cookies["name"],
                DateTime.Now,
                coin,
                "Cash Out");
            context.Add(cashOut);
            context.SaveChanges();

            Response.Cookies.Delete("name");
            Response.Cookies.Delete("coins");
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
