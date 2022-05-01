using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Prep.Models
{
    public class AutoContext : IdentityDbContext<User>
    {
        public AutoContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Part> Parts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // first call base class version:
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Manufacturer>().HasData(
                new Manufacturer()
                {
                    ManufacturerId = 1, 
                    Name = "Toyota",
                    Address = "Japan",
                    Website = "www.Toyota.com",
                    City = "Tokyo",
                    ZipCode = "12345"
                },

                new Manufacturer()
                {
                    ManufacturerId = 2,
                    Name = "Ford",
                    Address = "Japan",
                    Website = "www.Ford.com",
                    City = "Detroit",
                    ZipCode = "23456"
                }
            );

            modelBuilder.Entity<Car>().HasData(
                new Car()
                {
                    CarId = 1,
                    ManufacturerId = 1,
                    Make = "Toyota",
                    Model = "Corolla",
                    Year = 2022
                },

                new Car()
                {
                    CarId = 2,
                    ManufacturerId = 2,
                    Make = "Ford",
                    Model = "F-150",
                    Year = 2021
                }
            );

            modelBuilder.Entity<Part>().HasData(
                new Part()
                {
                    PartId = 1, CarId = 1, ItemsInStock = 5, PartName = "Wheel", Price = 200
                },
                
                new Part()
                {
                    PartId = 2, CarId = 1, ItemsInStock = 5, PartName = "Handle", Price = 200
                },

                new Part()
                {
                    PartId = 3, CarId = 2, ItemsInStock = 5, PartName = "Window", Price = 200
                },

                new Part()
                {
                    PartId = 4, CarId = 2, ItemsInStock = 5, PartName = "Door", Price = 200
                }
            );
        }
    }
}
