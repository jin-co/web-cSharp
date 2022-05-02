using System.ComponentModel.DataAnnotations;

namespace BookstoreApp.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }

        public string Title { get; set; }

        public string GenreID { get; set; }

        public Genre Genre { get; set; }

        public string AuthorID { get; set; }

        public Author Author { get; set; }

        public string PublisherID { get; set; }

        public Publisher Publisher { get; set; }

        public int Year { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public string LogoImageSource { get; set; }
    }
}
