using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            HttpContext.Session.SetString("newUser", player.Name);
            return Redirect("Home/Index");
        }
    }
}
