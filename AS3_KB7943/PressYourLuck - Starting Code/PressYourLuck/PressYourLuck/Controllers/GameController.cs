using Microsoft.AspNetCore.Mvc;
using PressYourLuck.Helpers;
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
            var tileList = GameHelper.GenerateNewGame();
            return View(tileList);
        }
    }
}
