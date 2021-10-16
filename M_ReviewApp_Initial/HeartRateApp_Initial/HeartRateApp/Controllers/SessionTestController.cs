using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using HeartRateApp.Models;
using Newtonsoft.Json;

namespace HeartRateApp.Controllers
{
    public class SessionTestController : Controller
    {
        public IActionResult Index()
        {
            int num = 0;
            num += 1;
            HttpContext.Session.SetInt32("num", num);

            // json format
            Team team = new Team { 
                TeamId = 1,
                Name = "Seatle"
            };

            // object to string
            string teamJson = JsonConvert.SerializeObject(team);
            HttpContext.Session.SetString("team", teamJson);

            // string to object
            string getTeamJson = HttpContext.Session.GetString("team");
            Team teamString = JsonConvert.DeserializeObject<Team>(teamJson);
            

            return View();
        }
    }
}
