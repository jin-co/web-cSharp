using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace L4_FutureValueWith_MVC.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options) { }

        // creating db set
        public DbSet<Movie> Movies { get; set; }

        // builds database using model(runs first when the app fires up)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieId = 1, Name = "Casablanca", Year = 1992, Rating = 5 }
                );
            
            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieId = 2, Name = "Wonder Woman", Year = 2017, Rating = 3}
                );
            
            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieId = 3, Name = "Moonstruck", Year = 1988, Rating = 4}
                );
        }
    }
}
