using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PressYourLuck.Helpers;
using PressYourLuck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressYourLuck.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = Request.Cookies["name"];            
            ViewBag.Coin = Request.Cookies["coins"];
            ViewBag.CurrentBet = HttpContext.Session.GetString("bet");
            var tileList = GameHelper.GenerateNewGame();

            HttpContext.Session.SetString("tiles", tileList.ToString());

            return View(tileList);
        }

        public IActionResult Bet(int index)
        {
            double bet = double.Parse(HttpContext.Session.GetString("bet"));
            double coin = double.Parse(Request.Cookies["coins"]);
            double cal = coin - bet;

            Response.Cookies.Append("coins", cal.ToString());

            ViewBag.Coin = Request.Cookies["coins"];

            return RedirectToAction("Index");
        }
    }
}
