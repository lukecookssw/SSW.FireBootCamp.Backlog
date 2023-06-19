﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SSW.WebApi.Data;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(WeatherDbContext))]
    [Migration("20221205013527_InitialDatabase")]
    partial class InitialDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SSW.WebApi.Data.Entities.WeatherForecast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WeatherForecasts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2022, 12, 6, 12, 35, 26, 929, DateTimeKind.Local).AddTicks(4229),
                            Summary = "Chilly",
                            TemperatureC = -10
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2022, 12, 7, 12, 35, 26, 929, DateTimeKind.Local).AddTicks(4297),
                            Summary = "Cool",
                            TemperatureC = 10
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2022, 12, 8, 12, 35, 26, 929, DateTimeKind.Local).AddTicks(4299),
                            Summary = "Hot",
                            TemperatureC = 30
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2022, 12, 9, 12, 35, 26, 929, DateTimeKind.Local).AddTicks(4302),
                            Summary = "Mild",
                            TemperatureC = 25
                        });
                });
#pragma warning restore 612, 618
        }
    }
}