using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2_TransactionRecord.Models
{
    public class TransactionContext : DbContext
    {
        public TransactionContext(
            DbContextOptions<TransactionContext> options) : base(options)
        { }

        // generates database table
        public DbSet<TransactionRecordKbaek7943> TransactionRecordKbaek7943s { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
        public DbSet<Company> Companies { get; set; }

        // seeds the initial data to the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TransactionType>().HasData(
                new TransactionType
                {
                    TransactionTypeId = "Buy",
                    Name = "Buy",
                    Commission = 5.99
                },

                new TransactionType
                {
                    TransactionTypeId = "Sell",
                    Name = "Sell",
                    Commission = 5.40
                }
            );

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    CompanyId = 1,
                    Name = "Microsoft",
                    Address = "USA",
                    TickerSymbol = "MSFT"
                },

                new Company
                {
                    CompanyId = 2,
                    Name = "Google",
                    Address = "USA",
                    TickerSymbol = "GOOG"
                }
            );

            modelBuilder.Entity<TransactionRecordKbaek7943>().HasData(
                new TransactionRecordKbaek7943
                {
                    TransactionRecordKbaek7943Id = 1,                    
                    Quantity = 100,
                    SharePrice = 123.45,
                    TransactionTypeId = "Sell",
                    CompanyId = 1
                },

                new TransactionRecordKbaek7943
                {
                    TransactionRecordKbaek7943Id = 2,                    
                    Quantity = 100,
                    SharePrice = 2701.76,
                    TransactionTypeId = "Buy",
                    CompanyId = 2
                }
            );
        }
    }
}
