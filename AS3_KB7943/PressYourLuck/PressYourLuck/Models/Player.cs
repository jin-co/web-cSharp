using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PressYourLuck.Models
{
    public class Player
    {
        public int PlayerId { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(1.00, 10000.00)]
        public double StartingCoins { get; set; }
    }
}
