using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PressYourLuck.Models
{
    public class Player
    {
        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }

        [Range(1.00, 10000.00, ErrorMessage = "coin numbers must be between 1 ~ 10000")]
        [RegularExpression(@"^\d+(?:\.\d{2})?$",
            ErrorMessage = "Please enter valid values(e.g. 00.00 or 00)")]
        public double StartingCoins { get; set; }
    }
}
