﻿// <auto-generated />
using System;
using FardaTaxi.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FardaTaxi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20231015123755_createDB")]
    partial class createDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.23");

            modelBuilder.Entity("FardaTaxi.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FaceImg")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("FardaTaxi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
