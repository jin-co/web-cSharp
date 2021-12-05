using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandboxApp_Week12.Models
{
    public class DropDownFilterViewModel
    {
        public Dictionary<string, string> MovieItems { get; set; }
        public Dictionary<string, string> GenreItems { get; set; }
        public Dictionary<string, string> RatingItems { get; set; }

        public string SelectedMovieValue { get; set; }
        public string DefaultMovieValue { get; set; }

        public string SelectedGenreValue { get; set; }
        public string DefaultGenreValue { get; set; }

        public string SelectedRatingValue { get; set; }
        public string DefaultRatingValue { get; set; }
    }
}
