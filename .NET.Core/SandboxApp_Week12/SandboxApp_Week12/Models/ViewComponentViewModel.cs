using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandboxApp_Week12.Models
{
    public class ViewComponentViewModel
    {
        public List<Movie> Movies { get; set; }

        public string DefaultMovieFilter { get; set; }

        public string DefaultGenreFilter { get; set; }

        public string DefaultRatingFilter { get; set; }
    }
}
