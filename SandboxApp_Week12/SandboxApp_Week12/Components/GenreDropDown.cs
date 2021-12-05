using Microsoft.AspNetCore.Mvc;
using SandboxApp_Week12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandboxApp_Week12.Components
{
    public class GenreDropDown : ViewComponent
    {
        private MovieContext _context;

        public GenreDropDown(MovieContext movieContext)
        {
            _context = movieContext;
        }

        public IViewComponentResult Invoke(string selectedMovieValue, string selectedGenreValue, string selectedRatingValue)
        {
            var movies = _context.Movies.OrderBy(ob => ob.Name).ToList();
            var ratings = _context.Movies.Select(s => s.Rating).Distinct().ToList();
            var genres = _context.Genres.OrderBy(ob => ob.Name).ToList();

            DropDownFilterViewModel ddfvm = new DropDownFilterViewModel()
            {
                MovieItems = movies.ToDictionary(d => d.MovieId.ToString(), d => d.Name),
                RatingItems = ratings.ToDictionary(d => d.Value.ToString(), d => d.Value.ToString()),
                GenreItems = genres.ToDictionary(d => d.GenreId.ToString(), d => d.Name),
                DefaultGenreValue = "All",
                DefaultMovieValue = "All",
                DefaultRatingValue = "All",
                SelectedMovieValue = selectedMovieValue,
                SelectedGenreValue = selectedGenreValue,
                SelectedRatingValue = selectedRatingValue
            };

            return View(ddfvm);
        }
    }
}
