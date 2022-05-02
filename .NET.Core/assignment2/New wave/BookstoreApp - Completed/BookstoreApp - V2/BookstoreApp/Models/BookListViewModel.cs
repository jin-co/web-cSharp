using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreApp.Models
{
    public class BookListViewModel : BookViewModel
    {
        public List<Book> Books;

        // Use the full properties for Genres, Authors, and Publishers
        // so that we can add the "All" item at the beginning
        private List<Genre> genres;

        public List<Genre> Genres
        {
            get => genres;
            set
            {
                genres = value;
                genres.Insert(0,
                    new Genre { GenreID = "all", Name = "All" });
            }
        }

        private List<Author> authors;

        public List<Author> Authors
        {
            get => authors;
            set
            {
                authors = value;
                authors.Insert(0,
                    new Author { AuthorID = "all", FullName = "All" });
            }
        }

        private List<Publisher> publishers;
        public List<Publisher> Publishers
        {
            get => publishers;
            set
            {
                publishers = value;
                publishers.Insert(0,
                    new Publisher { PublisherID = "all", Name = "All" });
            }
        }

        // Methods to help determine which are the active links
        public string CheckActiveGenre(string g) =>
            g.ToLower() == ActiveGenre.ToLower() ? "active" : "";

        public string CheckActiveAuthor(string a) =>
            a.ToLower() == ActiveAuthor.ToLower() ? "active" : "";

        public string CheckActivePublisher(string p) =>
            p.ToLower() == ActivePublisher.ToLower() ? "active" : "";
    }
}
