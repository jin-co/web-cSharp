using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PressYourLuck.Controllers
{
    public class PlayerController : Controller
    {
        [Required]
        public string Name { get; set; }

        [Range(1.00, 10000.00)]
        public double StartingCoins { get; set; }
    }
}
