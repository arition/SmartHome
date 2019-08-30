﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartHome;

namespace SmartHome.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20190829233017_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("SmartHome.Models.Humidity", b =>
                {
                    b.Property<int>("HumidityId")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("HumidityPercent");

                    b.Property<DateTime>("Time");

                    b.HasKey("HumidityId");

                    b.ToTable("Humidity");
                });

            modelBuilder.Entity("SmartHome.Models.Temperature", b =>
                {
                    b.Property<int>("TemperatureId")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("TemperatureCelsius");

                    b.Property<DateTime>("Time");

                    b.HasKey("TemperatureId");

                    b.ToTable("Temperature");
                });
#pragma warning restore 612, 618
        }
    }
}
