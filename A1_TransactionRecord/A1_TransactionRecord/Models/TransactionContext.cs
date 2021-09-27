using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A1_TransactionRecord.Models
{
    public class TransactionContext : DbContext
    {
        public TransactionContext(
            DbContextOptions<TransactionContext> options) : base(options)
        {}

        // generates database table
        public DbSet<TransactionRecordKbaek7943> TransactionRecordKbaek7943s { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }

        // seeds the initial data to the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransactionType>().HasData(
                new TransactionType
                {
                    TransactionTypeId = "Buy",
                    Name = "Buy",
                    Commission = 5.99,
                },

                new TransactionType
                {
                    TransactionTypeId = "Sell",
                    Name = "Sell",
                    Commission = 5.40
                }
            );

            modelBuilder.Entity<TransactionRecordKbaek7943>().HasData(
                new TransactionRecordKbaek7943
                {
                    TransactionRecordKbaek7943Id = 1,
                    TicketSymbol = "MSFT",
                    CompanyName = "Microsoft",
                    Quantity = 100,
                    SharePrice = 123.45,
                    TransactionTypeId = "Sell"
                },
                
                new TransactionRecordKbaek7943
                {
                    TransactionRecordKbaek7943Id = 2,
                    TicketSymbol = "GOOG",
                    CompanyName = "Google",
                    Quantity = 100,
                    SharePrice = 2701.76,
                    TransactionTypeId = "Buy"
                }

            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
