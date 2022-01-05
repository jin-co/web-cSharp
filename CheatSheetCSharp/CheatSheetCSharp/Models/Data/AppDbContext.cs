using CheatSheetCSharp.Filtering.Models;
using CheatSheetCSharp.Models.DomainModels;
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
    public class AppDbContext : IdentityDbContext<User>
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

        // Credential Db
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<Genre> Genres { get; set; }

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

            // Credential
            // BookAuthor: set primary key 
            modelBuilder.Entity<BookAuthor>().HasKey(ba => new { ba.BookId, ba.AuthorId });

            // BookAuthor: set foreign keys 
            modelBuilder.Entity<BookAuthor>().HasOne(ba => ba.Book)
                .WithMany(b => b.BookAuthors)
                .HasForeignKey(ba => ba.BookId);
            modelBuilder.Entity<BookAuthor>().HasOne(ba => ba.Author)
                .WithMany(a => a.BookAuthors)
                .HasForeignKey(ba => ba.AuthorId);

            // Book: remove cascading delete with Genre
            modelBuilder.Entity<Book>().HasOne(b => b.Genre)
                .WithMany(g => g.Books)
                .OnDelete(DeleteBehavior.Restrict);

            // seed initial data
            modelBuilder.ApplyConfiguration(new SeedGenres());
            modelBuilder.ApplyConfiguration(new SeedBooks());
            modelBuilder.ApplyConfiguration(new SeedAuthors());
            modelBuilder.ApplyConfiguration(new SeedBookAuthors());
        }

        // Credential
        public static async Task CreateAdminUser(IServiceProvider serviceProvider)
        {
            UserManager<User> userManager = serviceProvider.GetRequiredService<UserManager<User>>();
            RoleManager<IdentityRole> roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string username = "admin";
            string password = "P@ssw0rd!";
            string roleName = "Admin";

            // if role doesn't exist, create it
            if (await roleManager.FindByNameAsync(roleName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }

            // if username doesn't exist, create it and add it to role
            if (await userManager.FindByNameAsync(username) == null)
            {
                User user = new User { UserName = username };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, roleName);
                }
            }
        }

    }
}
