﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.DataAccess;

namespace WebApplication2.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20191119114600_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication2.Models.Client", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = "c639f2b2-4c5e-4e68-a395-65c62bbe33ca",
                            Name = "Аскар",
                            PhoneNumber = "+77017778899"
                        },
                        new
                        {
                            Id = "ea5b843d-596f-43a0-9d6f-f65de83fe408",
                            Name = "Олег Скидан",
                            PhoneNumber = "+77015554411"
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.Driver", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Car")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Drivers");

                    b.HasData(
                        new
                        {
                            Id = "86bbaa00-1ea9-4094-afbf-2dc4d1099b4c",
                            Car = "Range Rover Voque 3",
                            CarNumber = "z001mmm",
                            Name = "Graf Aleksandr III",
                            PhoneNumber = "+77013336655"
                        },
                        new
                        {
                            Id = "2eeb343f-f9ef-4d4c-9703-c13fe123e24a",
                            Car = "Maybach Original Reserve",
                            CarNumber = "kz001",
                            Name = "Kasym Jomart",
                            PhoneNumber = "+77010202022"
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.Location", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("WebApplication2.Models.Order", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationOrder")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DriverId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FromId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("FromId");

                    b.HasIndex("ToId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WebApplication2.Models.Order", b =>
                {
                    b.HasOne("WebApplication2.Models.Location", "From")
                        .WithMany()
                        .HasForeignKey("FromId");

                    b.HasOne("WebApplication2.Models.Location", "To")
                        .WithMany()
                        .HasForeignKey("ToId");
                });
#pragma warning restore 612, 618
        }
    }
}
