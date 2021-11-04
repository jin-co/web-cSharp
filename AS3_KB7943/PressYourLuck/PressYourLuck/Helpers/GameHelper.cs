using Microsoft.AspNetCore.Http;
using PressYourLuck.Models;
using PressYourLuck.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressYourLuck.Helpers
{
    public static class GameHelper
    {
        //This creates a collection of 12 tiles with randomly generated values
        public static List<Tile> GenerateNewGame()
        {
            var tileList = new List<Tile>();
            Random r = new Random();
            for (int i = 0; i < 12; i++)
            {
                double randomValue = 0;
                if (r.Next(1,4) != 1)
                {
                    randomValue = (r.NextDouble() + 0.5) * 2;
                }

                var tile = new Tile()
                {
                    TileIndex = i,
                    Visible = false,
                    Value = randomValue.ToString("N2")
                };

                tileList.Add(tile);

            }
            return tileList;
        }

        /*
        * HINT: HttpContext is not available in this class pass it into methods 
        */


        // - GetCurrentGame - If there is no current game state in session Generate a New Game
        // and store it in session, otherwise deserialize the List<Tile> from session
        public static List<Tile> GetCurrentGame(HttpContext httpContext)
        {
            var tileList = new List<Tile>();

            //code goes here

            return tileList;
        }

        // - SaveCurrentGame - Save the current state of the game to session. 
        public static void SaveCurrentGame(/* parameters? */)
        {
            //code goes here
        }

       /* - PickATileAndUpdateGame - code that contains the game logic as 
        * mentioned in Part 4 of the assignment. Hint: you'll need to pass in the
        * id of the selected tile as one of the parameters.
        */
        public static double PickTileAndUpdateGame(/* parameters? */)
        {
            //code goes here
            return 0.0;
        }

        // - ClearCurrentGame - clear the current game state from session
        public static void ClearCurrentGame(/* parameters? */)
        {
            //code goes here
        }

        //- Finally, methods to serialize and deserialzie the Tile list.
        public static string SerializeTileList(/* parameters? */)
        {
            var result = "";
            //code goes here
            return result;
        }

        public static List<Tile> DeserializeTileList(/* parameters? */)
        {
            var results = new List<Tile>();
            //code goes here
            return results;
        }
    }
}
