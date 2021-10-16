using System;
using Microsoft.EntityFrameworkCore;

namespace HeartRateApp.Models
{
    public class HeartRateDbContext : DbContext
    {
        public HeartRateDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<HeartRateMeasurement> HeartRateMeasurements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed our DB with some measurements:
            modelBuilder.Entity<HeartRateMeasurement>().HasData(
                new HeartRateMeasurement() { HeartRateMeasurementId = 1, BPMValue = 143, MeasurementDate = DateTime.Now },
                new HeartRateMeasurement() { HeartRateMeasurementId = 2, BPMValue = 156, MeasurementDate = DateTime.Now },
                new HeartRateMeasurement() { HeartRateMeasurementId = 3, BPMValue = 167, MeasurementDate = DateTime.Now });
        }
    }
}
