﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PasswordStorageApp.WebAPI.Persistens.Contexts;

#nullable disable

namespace PasswordStorageApp.WebAPI.Persistens.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240807111831_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("PasswordStorageApp.Domain.Models.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("MofifiedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(1);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Username");

                    b.ToTable("Account", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("71f3d31c-d0ef-11ee-a506-0242ac120002"),
                            CreatedOn = new DateTimeOffset(new DateTime(2023, 3, 15, 9, 30, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Password = "P@ssw0rd123!",
                            Type = 0,
                            Username = "johndoe"
                        },
                        new
                        {
                            Id = new Guid("71f3d5f6-d0ef-11ee-a506-0242ac120002"),
                            CreatedOn = new DateTimeOffset(new DateTime(2023, 5, 22, 14, 45, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Password = "SecurePass789#",
                            Type = 0,
                            Username = "janedoe"
                        },
                        new
                        {
                            Id = new Guid("71f3d75e-d0ef-11ee-a506-0242ac120002"),
                            CreatedOn = new DateTimeOffset(new DateTime(2023, 8, 7, 11, 15, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Password = "B0bsC0mpl3xP@ss",
                            Type = 0,
                            Username = "bobsmith"
                        },
                        new
                        {
                            Id = new Guid("71f3d88a-d0ef-11ee-a506-0242ac120002"),
                            CreatedOn = new DateTimeOffset(new DateTime(2023, 10, 30, 16, 20, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Password = "Al1c3J0hns0n2023!",
                            Type = 0,
                            Username = "alicejohnson"
                        },
                        new
                        {
                            Id = new Guid("71f3d9a2-d0ef-11ee-a506-0242ac120002"),
                            CreatedOn = new DateTimeOffset(new DateTime(2024, 1, 18, 8, 55, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Password = "M1k3R0ss#2024",
                            Type = 0,
                            Username = "mikeross"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
