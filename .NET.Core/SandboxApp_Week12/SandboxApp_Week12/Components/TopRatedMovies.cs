using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SandboxApp_Week12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandboxApp_Week12.Components
{
    public class TopRatedMovies : ViewComponent 
    {
        private MovieContext _context;
        public TopRatedMovies(MovieContext movieContext)
        {
            _context = movieContext;
        }

        public IViewComponentResult Invoke(int lowestRating, int NumberOfMoviesToDisplay)
        {
            var movies = _context.Movies
                .Include(i => i.Genre)
                .Where(w => w.Rating >= lowestRating)
                .OrderBy(m => m.Name)
                .ToList();

            var viewModel = new TopRatedViewModel()
            {
                Movies = movies,
                LowestRatingToDisplay = lowestRating,
                NumberOfMoviesToDisplay = Math.Min(movies.Count, NumberOfMoviesToDisplay)
            };

            return View(viewModel);
        }
    }
}
