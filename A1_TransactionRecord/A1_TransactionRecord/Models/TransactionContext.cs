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
        public DbSet<TransactionRecordKbaek7943> Transactions { get; set; }

        // seeds the initial data to the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransactionRecordKbaek7943>().HasData(
                new TransactionRecordKbaek7943
                {
                    TransactionId = 1,
                    TicketSymbol = "MSFT",
                    CompanyName = "Microsoft",
                    Quantity = 100,
                    SharePrice = 123.45
                },
                
                new TransactionRecordKbaek7943
                {
                    TransactionId = 2,
                    TicketSymbol = "GOOG",
                    CompanyName = "Google",
                    Quantity = 100,
                    SharePrice = 2701.76
                }

            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
