﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SurfsUp.Models;

#nullable disable

namespace SurfsUp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241001082907_Wetsuit")]
    partial class Wetsuit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SurfsUp.Models.Board", b =>
                {
                    b.Property<int>("BoardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BoardId"));

                    b.Property<string>("Equipment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBooked")
                        .HasColumnType("bit");

                    b.Property<double>("Length")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<double>("Thickness")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Volume")
                        .HasColumnType("float");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("BoardId");

                    b.ToTable("Boards", "SurfsUp");

                    b.HasData(
                        new
                        {
                            BoardId = 1,
                            Equipment = "",
                            ImagePath = "/images/surfboards/surfboard-1.jpg",
                            IsBooked = false,
                            Length = 6.0,
                            Name = "The Minilog",
                            Price = 565,
                            Thickness = 2.75,
                            Type = "Shortboard",
                            Volume = 38.799999999999997,
                            Width = 21.0
                        },
                        new
                        {
                            BoardId = 2,
                            Equipment = "",
                            ImagePath = "/images/surfboards/surfboard-2.jpg",
                            IsBooked = false,
                            Length = 7.0999999999999996,
                            Name = "The Wide Glider",
                            Price = 685,
                            Thickness = 2.75,
                            Type = "Funboard",
                            Volume = 44.159999999999997,
                            Width = 21.75
                        },
                        new
                        {
                            BoardId = 3,
                            Equipment = "",
                            ImagePath = "/images/surfboards/surfboard-3.jpg",
                            IsBooked = false,
                            Length = 6.2999999999999998,
                            Name = "The Golden Ratio",
                            Price = 695,
                            Thickness = 2.8999999999999999,
                            Type = "Funboard",
                            Volume = 43.219999999999999,
                            Width = 21.850000000000001
                        },
                        new
                        {
                            BoardId = 4,
                            Equipment = "",
                            ImagePath = "/images/surfboards/surfboard-4.jpg",
                            IsBooked = false,
                            Length = 5.4000000000000004,
                            Name = "Mahi Mahi",
                            Price = 645,
                            Thickness = 2.2999999999999998,
                            Type = "Fish",
                            Volume = 29.390000000000001,
                            Width = 20.75
                        },
                        new
                        {
                            BoardId = 5,
                            Equipment = "",
                            ImagePath = "/images/surfboards/surfboard-5.jpg",
                            IsBooked = false,
                            Length = 9.1999999999999993,
                            Name = "The Emerald Glider",
                            Price = 895,
                            Thickness = 2.7999999999999998,
                            Type = "Longboard",
                            Volume = 65.400000000000006,
                            Width = 22.800000000000001
                        },
                        new
                        {
                            BoardId = 6,
                            Equipment = "",
                            ImagePath = "/images/surfboards/surfboard-6.jpg",
                            IsBooked = false,
                            Length = 5.5,
                            Name = "The Bomb",
                            Price = 645,
                            Thickness = 2.5,
                            Type = "Shortboard",
                            Volume = 33.700000000000003,
                            Width = 21.0
                        },
                        new
                        {
                            BoardId = 7,
                            Equipment = "",
                            ImagePath = "/images/surfboards/surfboard-7.jpg",
                            IsBooked = false,
                            Length = 9.5999999999999996,
                            Name = "Walden Magic",
                            Price = 1025,
                            Thickness = 3.0,
                            Type = "Longboard",
                            Volume = 80.0,
                            Width = 19.399999999999999
                        },
                        new
                        {
                            BoardId = 8,
                            Equipment = "Paddle",
                            ImagePath = "/images/surfboards/surfboard-8.jpg",
                            IsBooked = false,
                            Length = 12.6,
                            Name = "Naish One",
                            Price = 854,
                            Thickness = 6.0,
                            Type = "SUP",
                            Volume = 301.0,
                            Width = 30.0
                        },
                        new
                        {
                            BoardId = 9,
                            Equipment = "Fin, Paddle, Pump, Leash",
                            ImagePath = "/images/surfboards/surfboard-9.jpg",
                            IsBooked = false,
                            Length = 11.6,
                            Name = "Six Tourer",
                            Price = 611,
                            Thickness = 6.0,
                            Type = "SUP",
                            Volume = 270.0,
                            Width = 32.0
                        },
                        new
                        {
                            BoardId = 10,
                            Equipment = "Fin, Paddle, Pump, Leash",
                            ImagePath = "/images/surfboards/surfboard-10.jpg",
                            IsBooked = false,
                            Length = 14.0,
                            Name = "Naish Maliko",
                            Price = 1304,
                            Thickness = 6.0,
                            Type = "SUP",
                            Volume = 330.0,
                            Width = 25.0
                        });
                });

            modelBuilder.Entity("SurfsUp.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<int>("BoardId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTo")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WetsuitId")
                        .HasColumnType("int");

                    b.Property<int?>("WetsuitSize")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("BoardId");

                    b.HasIndex("WetsuitId");

                    b.ToTable("Bookings", "SurfsUp");
                });

            modelBuilder.Entity("SurfsUp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users", "SurfsUp");
                });

            modelBuilder.Entity("SurfsUp.Models.Wetsuit", b =>
                {
                    b.Property<int>("WetsuitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WetsuitId"));

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Thickness")
                        .HasColumnType("float");

                    b.Property<int>("WetsuitSize")
                        .HasColumnType("int");

                    b.HasKey("WetsuitId");

                    b.ToTable("Wetsuits", "SurfsUp");

                    b.HasData(
                        new
                        {
                            WetsuitId = 1,
                            Gender = "Male",
                            ImagePath = "/images/wetsuits/wetsuit-1.jpg",
                            Name = "Furnace Natural",
                            Price = 565.0,
                            Thickness = 2.0,
                            WetsuitSize = 0
                        },
                        new
                        {
                            WetsuitId = 2,
                            Gender = "",
                            ImagePath = "/images/wetsuits/wetsuit-1.jpg",
                            Name = "",
                            Price = 565.0,
                            Thickness = 2.75,
                            WetsuitSize = 0
                        },
                        new
                        {
                            WetsuitId = 3,
                            Gender = "",
                            ImagePath = "/images/wetsuits/wetsuit-1.jpg",
                            Name = "",
                            Price = 565.0,
                            Thickness = 2.75,
                            WetsuitSize = 0
                        },
                        new
                        {
                            WetsuitId = 4,
                            Gender = "",
                            ImagePath = "/images/wetsuits/wetsuit-1.jpg",
                            Name = "",
                            Price = 565.0,
                            Thickness = 2.75,
                            WetsuitSize = 0
                        },
                        new
                        {
                            WetsuitId = 5,
                            Gender = "",
                            ImagePath = "/images/wetsuits/wetsuit-1.jpg",
                            Name = "",
                            Price = 565.0,
                            Thickness = 2.75,
                            WetsuitSize = 0
                        });
                });

            modelBuilder.Entity("SurfsUp.Models.Booking", b =>
                {
                    b.HasOne("SurfsUp.Models.Board", "Board")
                        .WithMany()
                        .HasForeignKey("BoardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SurfsUp.Models.Wetsuit", "Wetsuit")
                        .WithMany()
                        .HasForeignKey("WetsuitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Board");

                    b.Navigation("Wetsuit");
                });
#pragma warning restore 612, 618
        }
    }
}
