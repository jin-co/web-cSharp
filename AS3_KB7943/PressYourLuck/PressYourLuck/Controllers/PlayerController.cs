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
    // Player controller that manages calls for player pages
    public class PlayerController : Controller
    {
        private readonly PressLuckContext context;

        public PlayerController(PressLuckContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(Player player)
        {
            if (ModelState.IsValid)
            {
                var user = new UserCookies(Response.Cookies);
                user.SetUser(player.Name);
                user.SetCoin(player.StartingCoins.ToString());

                // save data
                var cashIn = new Audit(
                    player.Name,
                    DateTime.Now,
                    player.StartingCoins,
                    "Cash In");
                context.Add(cashIn);
                context.SaveChanges();

                return Redirect("/");
            }
            return View(player);
        }
    }
}
