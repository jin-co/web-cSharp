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
        public IActionResult Index(int bet)
        {
            //var playerJson = HttpContext.Session.GetString("newUser");
            //var player = new Player();
            
            //player = JsonConvert.DeserializeObject<Player>(playerJson);
            


            var tileList = GameHelper.GenerateNewGame();
            return View(tileList);
        }
    }
}
