using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PressYourLuck.Models.ViewModels
{
    public class CurrentGameModel
    {
        public CurrentGameModel() { }
        
        public CurrentGameModel(List<Tile> tiles)
        {
            Tiles = tiles;
        }

        public List<Tile> Tiles { get; set; }

        [RegularExpression(@"^\d+(?:\.\d{2})?$", 
            ErrorMessage = "Please enter valid values(e.g. 00.00 or 00)")]
        public double CurrentBettingAmount { get; set; }
    }
}
