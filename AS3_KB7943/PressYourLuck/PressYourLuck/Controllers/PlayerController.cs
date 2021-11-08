using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PressYourLuck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressYourLuck.Controllers
{
    public class PlayerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(Player player)
        {
            //var options = new CookieOptions
            //{
            //    Expires = DateTime.Now.AddDays(30)
            //};

            //if (ModelState.IsValid)
            //{
            //    Response.Cookies.Append("name", player.Name, options);
            //    Response.Cookies.Append("coins", player.StartingCoins.ToString(), options);
            //    return Redirect("/");
            //}

            if (ModelState.IsValid)
            {
                var user = new UserCookies(Response.Cookies);
                user.SetUser(player.Name);
                user.SetCoin(player.StartingCoins.ToString());
                return Redirect("/");
            }
            return View(player);
        }
    }
}
