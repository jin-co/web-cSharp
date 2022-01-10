using CheatSheetCSharp.Filtering.Models;
using CheatSheetCSharp.Session.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheatSheetCSharp.Models.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) {}

        // Filter Db
        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Status> Statuses { get; set; }

        // Session Db
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Company> Companies { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // DONT FORGET THIS (this ensures that the identitydbcontext above is able to run it's code logic before proceeding to the statements below).
            base.OnModelCreating(modelBuilder);

            // Filter data
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "work", Name = "Work" },
                new Category { CategoryId = "home", Name = "Home" },
                new Category { CategoryId = "ex", Name = "Exercise" },
                new Category { CategoryId = "shop", Name = "Shopping" },
                new Category { CategoryId = "call", Name = "Contact" }
            );
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = "open", Name = "Open" },
                new Status { StatusId = "closed", Name = "Completed" }
            );

            // Filter Seeding data
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleID = 1, Name = "Administrator" },
                new Role { RoleID = 2, Name = "Developer" },
                new Role { RoleID = 3, Name = "Analyst" }
            );

            modelBuilder.Entity<Company>().HasData(
                new Company { CompanyID = 1, Name = "Conestoga", TickerSymbol = "CON", Address = "123 Test Street" },
                new Company { CompanyID = 2, Name = "Microsoft", TickerSymbol = "MSFT", Address = "321 Microsoft Lane" }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeID = 1, FirstName = "Randy", LastName = "Daigle", Age = 39, RoleID = 1, CompanyID = 1 },
                new Employee { EmployeeID = 2, FirstName = "Jane", LastName = "Doe", Age = 28, RoleID = 3, CompanyID = 2 }
            );
        }
    }
}
