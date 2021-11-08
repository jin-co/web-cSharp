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
    public class GameController : Controller
    {        
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
            double coin = double.Parse(Request.Cookies["coins"]);
            double cal = coin - bet;

            CurrentGameModel cm = new CurrentGameModel();
            string currentGameJSON = HttpContext.Session.GetString("currentGame");
            var tileList = new List<Tile>();
            tileList = JsonConvert.DeserializeObject<List<Tile>>(currentGameJSON);
            tileList[index].Visible = true;

            Response.Cookies.Append("coins", cal.ToString());

            ViewBag.Coin = Request.Cookies["coins"];

            return View("Index", tileList);
        }
    }
}
