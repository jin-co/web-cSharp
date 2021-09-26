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
    }
}
