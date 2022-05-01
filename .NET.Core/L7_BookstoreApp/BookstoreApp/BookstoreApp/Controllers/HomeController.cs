using BookstoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreApp.Controllers
{
    public class HomeController : Controller
    {
        private BookContext context;

        public HomeController(BookContext ctx)
        {
            context = ctx;
        }

        public ViewResult Index(string activeGenre = "all", string activeAuthor = "all", string activePublisher = "all")
        {
            BookListViewModel bookList = new BookListViewModel()
            {
                ActiveGenre = activeGenre,
                ActiveAuthor = activeAuthor,
                ActivePublisher = activePublisher,
                Genres = context.Genres.ToList(),
                Authors = context.Authors.ToList(),
                Publishers = context.Publishers.ToList()
            };

            /* moved to BookList
            // store the selected genre, author, and publisher IDs in view bag properties
            ViewBag.ActiveGenre = activeGenre;
            ViewBag.ActiveAuthor = activeAuthor;
            ViewBag.ActivePublisher = activePublisher;

            // Get a list of genres, authors, and publishers from the database
            List<Genre> genres = context.Genres.ToList();
            List<Author> authors = context.Authors.ToList();
            List<Publisher> publishers = context.Publishers.ToList();

            // Insert a default option "All" at the front of each list
            genres.Insert(0, new Genre { GenreID = "all", Name = "All" });
            authors.Insert(0, new Author { AuthorID = "all", FullName = "All" });
            publishers.Insert(0, new Publisher { PublisherID = "all", Name = "All" });

            // Store each list in a ViewBag
            ViewBag.Genres = genres;
            ViewBag.Authors = authors;
            ViewBag.Publishers = publishers;
            */

            // Get list of books - filtered by genre, author, and publisher
            IQueryable<Book> query = context.Books;
            if (activeGenre != "all")
            {
                query = query.Where(w => w.Genre.GenreID.ToLower() == activeGenre.ToLower());
            }
            if (activeAuthor != "all")
            {
                query = query.Where(w => w.Author.AuthorID.ToLower() == activeAuthor.ToLower());
            }
            if (activePublisher != "all")
            {
                query = query.Where(w => w.Publisher.PublisherID.ToLower() == activePublisher.ToLower());
            }

            // return the book list to view as a model
            /*
            var books = query.ToList();
            return View(books);
            */
            bookList.Books = query.ToList();
            return View(bookList);
        }
    }
}
