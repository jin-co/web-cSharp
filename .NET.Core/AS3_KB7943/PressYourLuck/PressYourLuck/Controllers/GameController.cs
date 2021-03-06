using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PressYourLuck.Helpers;
using PressYourLuck.Models;
using PressYourLuck.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressYourLuck.Controllers
{
    // Game controller that manages calls for game play
    public class GameController : Controller
    {
        private readonly PressLuckContext context;

        public GameController(PressLuckContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Name = Request.Cookies["name"];
            ViewBag.Coin = Request.Cookies["coins"];
            ViewBag.CurrentBet = HttpContext.Session.GetString("bet");

            var tileList = GameHelper.GenerateNewGame();
            string currentGameJSON = JsonConvert.SerializeObject(tileList);
            HttpContext.Session.SetString("currentGame", currentGameJSON);
            
            return View(tileList);
        }

        public IActionResult Bet(int index)
        {
            double bet = double.Parse(HttpContext.Session.GetString("bet"));
            ViewBag.Coin = Request.Cookies["coins"];

            // get cookie
            string currentGameJSON = HttpContext.Session.GetString("currentGame");
            var tileList = new List<Tile>();
            tileList = JsonConvert.DeserializeObject<List<Tile>>(currentGameJSON);
            tileList[index].Visible = true;
            double chosenValue = double.Parse(tileList[index].Value);

            // bet result
            if (tileList[index].Value == "0.00")
            {
                //save data
                var lose = new Audit(
                    Request.Cookies["name"],
                    DateTime.Now,
                    bet,
                    "Lose");
                context.Add(lose);
                context.SaveChanges();

                bet = 0.00;
                TempData["Busted"] = "Oh no! You busted out. Better luck next time!";
                foreach (var i in tileList)
                {
                    i.Visible = true;
                }
            }
            else
            {
                //save data
                var win = new Audit(
                    Request.Cookies["name"],
                    DateTime.Now,
                    ((bet * chosenValue) - bet),
                    "Win");
                context.Add(win);
                context.SaveChanges();

                bet *= chosenValue;
                TempData["Found"] = $"Congrats You've found a {chosenValue} " +
                    $"Multiplier! All remaining values have doubled. Will you Press Your " +
                    $"Luck?";
                foreach (var i in tileList)
                {
                    if (i.Value != "0.00")
                    {
                        double multiplied = 0;
                        multiplied = double.Parse(i.Value) * 2;
                        i.Value = multiplied.ToString("N2");
                    }
                }
            }

            // set cookie
            string currentGameJSONSet = JsonConvert.SerializeObject(tileList);
            HttpContext.Session.SetString("currentGame", currentGameJSONSet);

            // current bet
            HttpContext.Session.SetString("bet", bet.ToString("N2"));
            ViewBag.CurrentBet = HttpContext.Session.GetString("bet");

            return View("Index", tileList);
        }

        public IActionResult TakeCoins()
        {
            double bet = double.Parse(HttpContext.Session.GetString("bet"));
            double coin = double.Parse(Request.Cookies["coins"]);
            double cal = coin + bet;
            // total coin 
            Response.Cookies.Append("coins", cal.ToString("N2"));

            //TempMessage
            TempData["Take"] = $"BIG WINNER! You cashed out for {cal} coins" +
                $" Care to press you luck again?";

            return Redirect("/");
        }

        public IActionResult TryAgain()
        {
            ViewBag.Name = Request.Cookies["name"];
            ViewBag.Coin = Request.Cookies["coins"];
            ViewBag.CurrentBet = HttpContext.Session.GetString("bet");

            if (double.Parse(Request.Cookies["coins"]) <= 0)
            {
                //TempMessage
                TempData["Broken"] = $"You've lost all you coins and must enter" +
                    $" more to keep playing";
                return Redirect("/Home/ClearUser");
            }            
            return Redirect("/");
        }
    }
}
