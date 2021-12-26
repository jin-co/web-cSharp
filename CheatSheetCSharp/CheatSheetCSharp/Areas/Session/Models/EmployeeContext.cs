using Microsoft.EntityFrameworkCore;

namespace CheatSheetCSharp.Session.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
          : base(options) { }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding my Role table
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleID = 1, Name = "Administrator" },
                new Role { RoleID = 2, Name = "Developer" },
                new Role { RoleID = 3, Name = "Analyst" }
            );

            // Seeding my Company table
            modelBuilder.Entity<Company>().HasData(
                new Company { CompanyID = 1, Name = "Conestoga", TickerSymbol = "CON", Address = "123 Test Street" },
                new Company { CompanyID = 2, Name = "Microsoft", TickerSymbol = "MSFT", Address = "321 Microsoft Lane" }
            );

            // Seeding my Employee table
            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeID = 1, FirstName = "Randy", LastName = "Daigle", Age = 39, RoleID = 1, CompanyID = 1 },
                new Employee { EmployeeID = 2, FirstName = "Jane", LastName = "Doe", Age = 28, RoleID = 3, CompanyID = 2 }
            );
        }
    }
}
