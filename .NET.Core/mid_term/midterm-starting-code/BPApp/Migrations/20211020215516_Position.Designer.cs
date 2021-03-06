// <auto-generated />
using System;
using BPApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BPApp.Migrations
{
    [DbContext(typeof(BPContext))]
    [Migration("20211020215516_Position")]
    partial class Position
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BPApp.Models.BPMeasurement", b =>
                {
                    b.Property<int>("BPMeasurementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Diastolic")
                        .HasColumnType("int");

                    b.Property<DateTime>("MeasurementDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PositionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Systolic")
                        .HasColumnType("int");

                    b.HasKey("BPMeasurementId");

                    b.HasIndex("PositionId");

                    b.ToTable("BPMeasurements");

                    b.HasData(
                        new
                        {
                            BPMeasurementId = 1,
                            Diastolic = 78,
                            MeasurementDate = new DateTime(1996, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PositionId = "Lying down",
                            Systolic = 118
                        },
                        new
                        {
                            BPMeasurementId = 2,
                            Diastolic = 79,
                            MeasurementDate = new DateTime(1998, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PositionId = "Standing",
                            Systolic = 122
                        },
                        new
                        {
                            BPMeasurementId = 3,
                            Diastolic = 85,
                            MeasurementDate = new DateTime(2002, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PositionId = "Sitting",
                            Systolic = 131
                        },
                        new
                        {
                            BPMeasurementId = 4,
                            Diastolic = 91,
                            MeasurementDate = new DateTime(2005, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PositionId = "Standing",
                            Systolic = 142
                        },
                        new
                        {
                            BPMeasurementId = 5,
                            Diastolic = 121,
                            MeasurementDate = new DateTime(2008, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PositionId = "Sitting",
                            Systolic = 181
                        });
                });

            modelBuilder.Entity("BPApp.Models.Position", b =>
                {
                    b.Property<string>("PositionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PositionId");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            PositionId = "Standing",
                            Name = "Standing"
                        },
                        new
                        {
                            PositionId = "Sitting",
                            Name = "Sitting"
                        },
                        new
                        {
                            PositionId = "Lying down",
                            Name = "Lying down"
                        });
                });

            modelBuilder.Entity("BPApp.Models.BPMeasurement", b =>
                {
                    b.HasOne("BPApp.Models.Position", "Positions")
                        .WithMany()
                        .HasForeignKey("PositionId");

                    b.Navigation("Positions");
                });
#pragma warning restore 612, 618
        }
    }
}
