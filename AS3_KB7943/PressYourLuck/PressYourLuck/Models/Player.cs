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
        public double StartingCoins { get; set; }

        [Range(1.00, 10000.00, ErrorMessage = "bet must be greater than 1")]
        public double? Bet { get; set; }
    }
}
