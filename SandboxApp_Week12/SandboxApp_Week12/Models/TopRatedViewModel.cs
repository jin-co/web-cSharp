using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandboxApp_Week12.Models
{
    public class TopRatedViewModel
    {
        public List<Movie> Movies { get; set; }
        public int LowestRatingToDisplay { get; set; }
        public int NumberOfMoviesToDisplay { get; set; }
    }
}
