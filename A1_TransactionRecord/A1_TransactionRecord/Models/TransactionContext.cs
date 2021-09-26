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

        public DbSet<TransactionRecord> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransactionRecord>().HasData(
                new TransactionRecord
                {
                    TicketSymbol = "MSFT",
                    CompanyName = "Microsoft",
                    Quantity = 100,
                    SharePrice = 123.45
                },
                
                new TransactionRecord
                {
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
