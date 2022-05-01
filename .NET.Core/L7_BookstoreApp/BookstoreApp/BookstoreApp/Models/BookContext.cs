using Microsoft.EntityFrameworkCore;

namespace BookstoreApp.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Author>().HasData(
                new Author { AuthorID = "JKR", FullName = "J.K. Rowling" },
                new Author { AuthorID = "JP", FullName = "James Paterson" },
                new Author { AuthorID = "SK", FullName = "Stephen King" },
                new Author { AuthorID = "CJ", FullName = "Craig Johnson" },
                new Author { AuthorID = "KM", FullName = "Kyle Mills" }
            );

            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreID = "F", Name = "Fiction" },
                new Genre { GenreID = "M", Name = "Mystery" },
                new Genre { GenreID = "R", Name = "Romance" },
                new Genre { GenreID = "A", Name = "Adventure" },
                new Genre { GenreID = "H", Name = "Horror" }
            );

            modelBuilder.Entity<Publisher>().HasData(
                new Publisher { PublisherID = "H", Name = "Hachette" },
                new Publisher { PublisherID = "C", Name = "Conestoga" },
                new Publisher { PublisherID = "MH", Name = "McGraw-Hill" },
                new Publisher { PublisherID = "S", Name = "Scholastics" },
                new Publisher { PublisherID = "SN", Name = "Springer Nature" }
            );

            modelBuilder.Entity<Book>().HasData(
                new Book { BookID = 1, Title = "Fiction 1", AuthorID = "JKR", GenreID = "F", PublisherID = "SN", Quantity = 20, Year = 2009, LogoImageSource = "fiction.jpg", Price = 19.40 },
                new Book { BookID = 2, Title = "Fiction 2", AuthorID = "CJ", GenreID = "F", PublisherID = "C", Quantity = 15, Year = 2005, LogoImageSource = "fiction.jpg", Price = 25.12 },
                new Book { BookID = 3, Title = "Horror 1", AuthorID = "SK", GenreID = "H", PublisherID = "MH", Quantity = 2, Year = 2001, LogoImageSource = "horror.jpg", Price = 12.76 },
                new Book { BookID = 4, Title = "Adventure 1", AuthorID = "JKR", GenreID = "A", PublisherID = "C", Quantity = 0, Year = 2008, LogoImageSource = "adventure.jpg", Price = 27.87 },
                new Book { BookID = 5, Title = "Adventure 2", AuthorID = "JP", GenreID = "A", PublisherID = "S", Quantity = 25, Year = 2004, LogoImageSource = "adventure.jpg", Price = 14.59 },
                new Book { BookID = 6, Title = "Romance 1", AuthorID = "JP", GenreID = "R", PublisherID = "SN", Quantity = 12, Year = 2019, LogoImageSource = "romance.jpg", Price = 12.45 },
                new Book { BookID = 7, Title = "Romance 2", AuthorID = "JKR", GenreID = "R", PublisherID = "C", Quantity = 3, Year = 2010, LogoImageSource = "romance.jpg", Price = 9.76 },
                new Book { BookID = 8, Title = "Horror 2", AuthorID = "SK", GenreID = "H", PublisherID = "MH", Quantity = 35, Year = 1990, LogoImageSource = "horror.jpg", Price = 10.43 },
                new Book { BookID = 9, Title = "Mystery 1", AuthorID = "KM", GenreID = "M", PublisherID = "SN", Quantity = 9, Year = 1989, LogoImageSource = "mystery.jpg", Price = 32.23 },
                new Book { BookID = 10, Title = "Mystery 2", AuthorID = "CJ", GenreID = "M", PublisherID = "H", Quantity = 7, Year = 2021, LogoImageSource = "mystery.jpg", Price = 12.67 },
                new Book { BookID = 11, Title = "Adventure 3", AuthorID = "JP", GenreID = "A", PublisherID = "H", Quantity = 17, Year = 2013, LogoImageSource = "adventure.jpg", Price = 52.67 }
            );
        }
    }
}
