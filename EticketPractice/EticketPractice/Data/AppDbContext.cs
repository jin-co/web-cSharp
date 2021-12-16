using EticketPractice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EticketPractice.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // creating compound primary key
            modelBuilder.Entity<ActorMovie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            // setting foreign key
            modelBuilder.Entity<ActorMovie>().HasOne(m => m.Movie).WithMany(am => am.ActorMovies)
                .HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<ActorMovie>().HasOne(m => m.Actor).WithMany(am => am.ActorMovies)
                .HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
