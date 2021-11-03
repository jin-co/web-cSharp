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
        [HttpPost]
        public IActionResult Index()
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                var tileList = GameHelper.GenerateNewGame();
                return View(tileList);
            }
        }
    }
}
