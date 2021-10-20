﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BPApp.Models
{
    public class BPContext : DbContext
    {
        public BPContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<BPMeasurement> BPMeasurements { get; set; }
        public DbSet<Position> Positions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Position>().HasData(
                new Position()
                {
                    PositionId = "Standing",
                    Name = "Standing"
                },

                new Position()
                {
                    PositionId = "Sitting",
                    Name = "Sitting"
                },

                new Position()
                {
                    PositionId = "Lying down",
                    Name = "Lying down"
                }
            );

            modelBuilder.Entity<BPMeasurement>().HasData(
                new BPMeasurement() 
                { 
                    BPMeasurementId = 1, 
                    Systolic = 118, 
                    Diastolic = 78, 
                    MeasurementDate = new DateTime(1996, 2, 9),
                    PositionId = "Lying down"
                },
                new BPMeasurement() 
                { 
                    BPMeasurementId = 2, 
                    Systolic = 122, 
                    Diastolic = 79, 
                    MeasurementDate = new DateTime(1998, 5, 8),
                    PositionId = "Standing"
                },
                new BPMeasurement() 
                { 
                    BPMeasurementId = 3, 
                    Systolic = 131, 
                    Diastolic = 85, 
                    MeasurementDate = new DateTime(2002, 11, 24),
                    PositionId = "Sitting"
                },
                new BPMeasurement() 
                { 
                    BPMeasurementId = 4, 
                    Systolic = 142, 
                    Diastolic = 91, 
                    MeasurementDate = new DateTime(2005, 12, 29),
                    PositionId = "Standing"
                },
                new BPMeasurement() 
                { 
                    BPMeasurementId = 5, 
                    Systolic = 181, 
                    Diastolic = 121, 
                    MeasurementDate = new DateTime(2008, 2, 7),
                    PositionId = "Sitting"
                }
            );
        }
    }
}
