using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SandboxApp_Week12.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SandboxApp_Week12.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _context;

        public HomeController(MovieContext movieContext)
        {
            _context = movieContext;
        }

        public IActionResult Index()
        {
            TempData["message"] = "Welcome to the tag helpers page!";
            return View();
        }

        public IActionResult TagHelpers()
        {
            return View();
        }

        public IActionResult PartialViews()
        {
            PartialViewModel pvm = new PartialViewModel();
            
            Book book = new Book();
            book.BookId = 1;
            book.Title = "Prog 2230";

            Colour colour = new Colour();
            colour.Name = "Blue";

            pvm.Book = book;
            pvm.Colour = colour;

            return View(pvm);
        }

        public IActionResult ViewComponents()
        {
            ViewComponentViewModel vcvm = new ViewComponentViewModel()
            {
                Movies = _context.Movies.Include(i => i.Genre).ToList(),
                DefaultMovieFilter = "All",
                DefaultGenreFilter = "All",
                DefaultRatingFilter = "All"
            };

            return View(vcvm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
