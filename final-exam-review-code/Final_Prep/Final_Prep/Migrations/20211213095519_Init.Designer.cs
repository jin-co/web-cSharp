﻿// <auto-generated />
using Final_Prep.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Final_Prep.Migrations
{
    [DbContext(typeof(AutoContext))]
    [Migration("20211213095519_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Final_Prep.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("CarId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            CarId = 1,
                            Make = "Toyota",
                            ManufacturerId = 1,
                            Model = "Corolla",
                            Year = 2022
                        },
                        new
                        {
                            CarId = 2,
                            Make = "Ford",
                            ManufacturerId = 2,
                            Model = "F-150",
                            Year = 2021
                        });
                });

            modelBuilder.Entity("Final_Prep.Models.Manufacturer", b =>
                {
                    b.Property<int>("ManufacturerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ManufacturerId");

                    b.ToTable("Manufacturers");

                    b.HasData(
                        new
                        {
                            ManufacturerId = 1,
                            Address = "Japan",
                            City = "Tokyo",
                            Name = "Toyota",
                            Website = "www.Toyota.com",
                            ZipCode = "12345"
                        },
                        new
                        {
                            ManufacturerId = 2,
                            Address = "Japan",
                            City = "Detroit",
                            Name = "Ford",
                            Website = "www.Ford.com",
                            ZipCode = "23456"
                        });
                });

            modelBuilder.Entity("Final_Prep.Models.Part", b =>
                {
                    b.Property<int>("PartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("ItemsInStock")
                        .HasColumnType("int");

                    b.Property<string>("PartName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("PartId");

                    b.HasIndex("CarId");

                    b.ToTable("Parts");

                    b.HasData(
                        new
                        {
                            PartId = 1,
                            CarId = 1,
                            ItemsInStock = 5,
                            PartName = "Wheel",
                            Price = 200.0
                        },
                        new
                        {
                            PartId = 2,
                            CarId = 1,
                            ItemsInStock = 5,
                            PartName = "Handle",
                            Price = 200.0
                        },
                        new
                        {
                            PartId = 3,
                            CarId = 2,
                            ItemsInStock = 5,
                            PartName = "Window",
                            Price = 200.0
                        },
                        new
                        {
                            PartId = 4,
                            CarId = 2,
                            ItemsInStock = 5,
                            PartName = "Door",
                            Price = 200.0
                        });
                });

            modelBuilder.Entity("Final_Prep.Models.Car", b =>
                {
                    b.HasOne("Final_Prep.Models.Manufacturer", "Manufacturer")
                        .WithMany("Cars")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("Final_Prep.Models.Part", b =>
                {
                    b.HasOne("Final_Prep.Models.Car", "Car")
                        .WithMany("Parts")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("Final_Prep.Models.Car", b =>
                {
                    b.Navigation("Parts");
                });

            modelBuilder.Entity("Final_Prep.Models.Manufacturer", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
