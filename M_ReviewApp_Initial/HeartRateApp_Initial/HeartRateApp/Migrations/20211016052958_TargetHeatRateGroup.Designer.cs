﻿// <auto-generated />
using System;
using HeartRateApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HeartRateApp.Migrations
{
    [DbContext(typeof(HeartRateDbContext))]
    [Migration("20211016052958_TargetHeatRateGroup")]
    partial class TargetHeatRateGroup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HeartRateApp.Models.HeartRateMeasurement", b =>
                {
                    b.Property<int>("HeartRateMeasurementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BPMValue")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("MeasurementDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TargetHeartRateGroupId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("HeartRateMeasurementId");

                    b.HasIndex("TargetHeartRateGroupId");

                    b.ToTable("HeartRateMeasurements");

                    b.HasData(
                        new
                        {
                            HeartRateMeasurementId = 1,
                            BPMValue = 143,
                            MeasurementDate = new DateTime(2021, 10, 16, 14, 29, 57, 733, DateTimeKind.Local).AddTicks(1054),
                            TargetHeartRateGroupId = "45years"
                        },
                        new
                        {
                            HeartRateMeasurementId = 2,
                            BPMValue = 156,
                            MeasurementDate = new DateTime(2021, 10, 16, 14, 29, 57, 733, DateTimeKind.Local).AddTicks(1699),
                            TargetHeartRateGroupId = "65years"
                        },
                        new
                        {
                            HeartRateMeasurementId = 3,
                            BPMValue = 167,
                            MeasurementDate = new DateTime(2021, 10, 16, 14, 29, 57, 733, DateTimeKind.Local).AddTicks(1702),
                            TargetHeartRateGroupId = "20years"
                        });
                });

            modelBuilder.Entity("HeartRateApp.Models.TargetHeartRateGroup", b =>
                {
                    b.Property<string>("TargetHeartRateGroupId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("AverageMaximumBPMValue")
                        .HasColumnType("int");

                    b.Property<int>("LowerEndBPMValue")
                        .HasColumnType("int");

                    b.Property<int>("UpperEndBPMValue")
                        .HasColumnType("int");

                    b.HasKey("TargetHeartRateGroupId");

                    b.ToTable("TargetHeartRateGroups");

                    b.HasData(
                        new
                        {
                            TargetHeartRateGroupId = "20years",
                            Age = 20,
                            AverageMaximumBPMValue = 200,
                            LowerEndBPMValue = 100,
                            UpperEndBPMValue = 170
                        },
                        new
                        {
                            TargetHeartRateGroupId = "30years",
                            Age = 30,
                            AverageMaximumBPMValue = 190,
                            LowerEndBPMValue = 92,
                            UpperEndBPMValue = 162
                        },
                        new
                        {
                            TargetHeartRateGroupId = "35years",
                            Age = 35,
                            AverageMaximumBPMValue = 185,
                            LowerEndBPMValue = 93,
                            UpperEndBPMValue = 157
                        },
                        new
                        {
                            TargetHeartRateGroupId = "40years",
                            Age = 40,
                            AverageMaximumBPMValue = 180,
                            LowerEndBPMValue = 90,
                            UpperEndBPMValue = 153
                        },
                        new
                        {
                            TargetHeartRateGroupId = "45years",
                            Age = 45,
                            AverageMaximumBPMValue = 175,
                            LowerEndBPMValue = 88,
                            UpperEndBPMValue = 149
                        },
                        new
                        {
                            TargetHeartRateGroupId = "50years",
                            Age = 50,
                            AverageMaximumBPMValue = 170,
                            LowerEndBPMValue = 85,
                            UpperEndBPMValue = 145
                        },
                        new
                        {
                            TargetHeartRateGroupId = "55years",
                            Age = 55,
                            AverageMaximumBPMValue = 165,
                            LowerEndBPMValue = 83,
                            UpperEndBPMValue = 140
                        },
                        new
                        {
                            TargetHeartRateGroupId = "60years",
                            Age = 60,
                            AverageMaximumBPMValue = 160,
                            LowerEndBPMValue = 80,
                            UpperEndBPMValue = 136
                        },
                        new
                        {
                            TargetHeartRateGroupId = "65years",
                            Age = 65,
                            AverageMaximumBPMValue = 155,
                            LowerEndBPMValue = 78,
                            UpperEndBPMValue = 132
                        },
                        new
                        {
                            TargetHeartRateGroupId = "70years",
                            Age = 70,
                            AverageMaximumBPMValue = 150,
                            LowerEndBPMValue = 75,
                            UpperEndBPMValue = 132
                        });
                });

            modelBuilder.Entity("HeartRateApp.Models.HeartRateMeasurement", b =>
                {
                    b.HasOne("HeartRateApp.Models.TargetHeartRateGroup", "TargetHeartRateGroup")
                        .WithMany()
                        .HasForeignKey("TargetHeartRateGroupId");

                    b.Navigation("TargetHeartRateGroup");
                });
#pragma warning restore 612, 618
        }
    }
}