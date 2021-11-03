﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PressYourLuck.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PressYourLuck.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var playerJson = HttpContext.Session.GetString("newUser");
            var player = new Player();
            if (HttpContext.Session.GetString("newUser") != null)
            {
                player = JsonConvert.DeserializeObject<Player>(playerJson);
                ViewBag.Name = player.Name;
                ViewBag.Coin = player.StartingCoins;
                return View();
            }       
            else
            {
                return Redirect("Player/Index");
            }
        }

        public IActionResult ClearUser()
        {
            HttpContext.Session.Remove("newUser");
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
