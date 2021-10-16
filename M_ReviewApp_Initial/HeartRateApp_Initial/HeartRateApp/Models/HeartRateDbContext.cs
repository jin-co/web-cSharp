using System;
using Microsoft.EntityFrameworkCore;

namespace HeartRateApp.Models
{
    public class HeartRateDbContext : DbContext
    {
        public HeartRateDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<HeartRateMeasurement> HeartRateMeasurements { get; set; }
        public DbSet<TargetHeartRateGroup> TargetHeartRateGroups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TargetHeartRateGroup>().HasData(
                 new TargetHeartRateGroup()
                 {
                     TargetHeartRateGroupId = "20years",
                     Age = 20,
                     LowerEndBPMValue = 100,
                     UpperEndBPMValue = 170,
                     AverageMaximumBPMValue = 200,
                 },
                new TargetHeartRateGroup()
                {
                    TargetHeartRateGroupId = "30years",
                    Age = 30,
                    LowerEndBPMValue = 92,
                    UpperEndBPMValue = 162,
                    AverageMaximumBPMValue = 190,
                },
                new TargetHeartRateGroup()
                {
                    TargetHeartRateGroupId = "35years",
                    Age = 35,
                    LowerEndBPMValue = 93,
                    UpperEndBPMValue = 157,
                    AverageMaximumBPMValue = 185,
                },
                new TargetHeartRateGroup()
                {
                    TargetHeartRateGroupId = "40years",
                    Age = 40,
                    LowerEndBPMValue = 90,
                    UpperEndBPMValue = 153,
                    AverageMaximumBPMValue = 180,
                },
                new TargetHeartRateGroup()
                {
                    TargetHeartRateGroupId = "45years",
                    Age = 45,
                    LowerEndBPMValue = 88,
                    UpperEndBPMValue = 149,
                    AverageMaximumBPMValue = 175,
                },
                new TargetHeartRateGroup()
                {
                    TargetHeartRateGroupId = "50years",
                    Age = 50,
                    LowerEndBPMValue = 85,
                    UpperEndBPMValue = 145,
                    AverageMaximumBPMValue = 170,
                },
                new TargetHeartRateGroup()
                {
                    TargetHeartRateGroupId = "55years",
                    Age = 55,
                    LowerEndBPMValue = 83,
                    UpperEndBPMValue = 140,
                    AverageMaximumBPMValue = 165,
                },
                new TargetHeartRateGroup()
                {
                    TargetHeartRateGroupId = "60years",
                    Age = 60,
                    LowerEndBPMValue = 80,
                    UpperEndBPMValue = 136,
                    AverageMaximumBPMValue = 160,
                },
                new TargetHeartRateGroup()
                {
                    TargetHeartRateGroupId = "65years",
                    Age = 65,
                    LowerEndBPMValue = 78,
                    UpperEndBPMValue = 132,
                    AverageMaximumBPMValue = 155,
                },
                new TargetHeartRateGroup()
                {
                    TargetHeartRateGroupId = "70years",
                    Age = 70,
                    LowerEndBPMValue = 75,
                    UpperEndBPMValue = 132,
                    AverageMaximumBPMValue = 150,
                }
            );

            // seed our DB with some measurements:
            modelBuilder.Entity<HeartRateMeasurement>().HasData(
                new HeartRateMeasurement() { 
                    HeartRateMeasurementId = 1, 
                    BPMValue = 143, 
                    MeasurementDate = DateTime.Now,
                    TargetHeartRateGroupId = "45years"
                },
                new HeartRateMeasurement() { 
                    HeartRateMeasurementId = 2, 
                    BPMValue = 156, 
                    MeasurementDate = DateTime.Now,
                    TargetHeartRateGroupId = "65years"
                },
                new HeartRateMeasurement() { 
                    HeartRateMeasurementId = 3, 
                    BPMValue = 167, 
                    MeasurementDate = DateTime.Now,
                    TargetHeartRateGroupId = "20years"
                }
            );
        }
    }
}
