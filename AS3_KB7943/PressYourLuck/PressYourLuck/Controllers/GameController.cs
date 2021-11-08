﻿using Microsoft.AspNetCore.Http;
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
            //double bet = double.Parse(HttpContext.Session.GetString("bet"));
            //double coin = double.Parse(Request.Cookies["coins"]);
            //double cal = coin - bet;

            //// total coin 
            //Response.Cookies.Append("coins", cal.ToString());

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
            //double coin = double.Parse(Request.Cookies["coins"]);
            //double cal = coin - bet;

            //// total coin 
            //Response.Cookies.Append("coins", cal.ToString());
            //ViewBag.Coin = Request.Cookies["coins"];

            // get cookie
            string currentGameJSON = HttpContext.Session.GetString("currentGame");
            var tileList = new List<Tile>();
            tileList = JsonConvert.DeserializeObject<List<Tile>>(currentGameJSON);
            tileList[index].Visible = true;

            // bet result
            if (tileList[index].Value == "0.00")
            {
                bet = 0.00;
            }
            else
            {
                bet *= double.Parse(tileList[index].Value);
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
            //ViewBag.Coin = Request.Cookies["coins"];

            return Redirect("/");
        }
    }
}
