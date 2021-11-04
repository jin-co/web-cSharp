﻿using Microsoft.AspNetCore.Http;
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
            //ViewBag.Name = Request.Cookies["name"];
            //ViewBag.Coin = Request.Cookies["coins"];
            //ViewBag.CurrentBet = HttpContext.Session.GetString("bet");
            var tileList = GameHelper.GenerateNewGame();
            return View(tileList);
        }
    }
}
