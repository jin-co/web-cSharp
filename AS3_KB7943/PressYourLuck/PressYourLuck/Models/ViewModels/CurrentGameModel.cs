using System;
using System.Collections.Generic;
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
        public double CurrentBettingAmount { get; set; }
    }
}
