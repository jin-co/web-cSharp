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

        // seeds the initial data to the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TransactionRecordKbaek7943>().HasData(
                new TransactionRecordKbaek7943
                {
                    TransactionRecordKbaek7943Id = 1,
                    TicketSymbol = "MSFT",
                    CompanyName = "Microsoft",
                    Quantity = 100,
                    SharePrice = 123.45                    
                },

                new TransactionRecordKbaek7943
                {
                    TransactionRecordKbaek7943Id = 2,
                    TicketSymbol = "GOOG",
                    CompanyName = "Google",
                    Quantity = 100,
                    SharePrice = 2701.76                    
                }
            );
        }
    }
}
