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
            //var playerJson = HttpContext.Session.GetString("newUser");
            //var player = new Player();

            //player = JsonConvert.DeserializeObject<Player>(playerJson);

            ViewBag.Name = Request.Cookies["name"];
            ViewBag.Coin = Request.Cookies["coins"];

            var tileList = GameHelper.GenerateNewGame();
            return View(tileList);
        }
    }
}
