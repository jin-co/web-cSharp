using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreApp.Models
{
    /*
     * refactoring view models so that i don't have to go back and 
     * forth to get and return the data
     */
    public class BookList
    {
        public List<Book> Books { get; set; }
        public string ActiveGenre { get; set; }
        public string ActiveAuthor { get; set; }
        public string ActivePublisher { get; set; }
        private List<Genre> genres { get; set; }
        public List<Genre> Genres
        {
            get => genres;
            set
            {
                genres = value;
                genres.Insert(0, new Genre { GenreID = "all", Name = "All" });
            }
        }

        public List<Author> authors { get; set; }

        public List<Author> Authors
        {
            get => authors;
            set
            {
                authors = value;
                authors.Insert(0, new Author { AuthorID = "all", FullName = "All" });
            }
        }
        private List<Publisher> publishers { get; set; }

        public List<Publisher> Publishers
        {
            get => publishers;
            set
            {
                publishers = value;
                publishers.Insert(0, new Publisher { PublisherID = "all", Name = "All" });
            }
        }

        public string CheckActiveGenre(string genre) 
            => genre.ToLower() == ActiveGenre.ToLower() ? "active" : "";

        public string CheckActiveAuthor(string author) 
            => author.ToLower() == ActiveAuthor.ToLower() ? "active" : "";
        
        public string CheckActivePublisher(string publisher) 
            => publisher.ToLower() == ActivePublisher.ToLower() ? "active" : "";
        
    }
}
