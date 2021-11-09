using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressYourLuck.Models
{
    public class PressLuckContext : DbContext
    {
        // DB creating
        public PressLuckContext(
            DbContextOptions<PressLuckContext> options) : base(options) { }

        // generates database table
        public DbSet<Audit> Audits { get; set; }
        //public DbSet<AuditType> AuditTypes { get; set; }

        // seed values
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<AuditType>().HasData(
            //    new AuditType
            //    {
            //        AuditTypeId = "Cash In",
            //        Name = "Cash In"
            //    },
            //    new AuditType
            //    {
            //        AuditTypeId = "Cash Out",
            //        Name = "Cash Out"
            //    },
            //    new AuditType
            //    {
            //        AuditTypeId = "Win",
            //        Name = "Win"
            //    },
            //    new AuditType
            //    {
            //        AuditTypeId = "Lose",
            //        Name = "Lose"
            //    }
            //);

            modelBuilder.Entity<Audit>().HasData(
                new Audit
                {
                    AutidId = 1,
                    PlayerName = "Jack",
                    CreatedDate = DateTime.Now,
                    Amount = 400
                    //AuditTypeId = "Cash In"
                },
                new Audit
                {
                    AutidId = 2,
                    PlayerName = "Rack",
                    CreatedDate = DateTime.Now,
                    Amount = 400
                    //AuditTypeId = "Cash Out"
                },
                new Audit
                {
                    AutidId = 3,
                    PlayerName = "Hack",
                    CreatedDate = DateTime.Now,
                    Amount = 430
                    //AuditTypeId = "Win"
                },
                new Audit
                {
                    AutidId = 4,
                    PlayerName = "Zack",
                    CreatedDate = DateTime.Now,
                    Amount = 450
                    //AuditTypeId = "Lose"
                }
            );
        }
    }
}
