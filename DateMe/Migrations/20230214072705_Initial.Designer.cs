﻿// <auto-generated />
using DateMe.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DateMe.Migrations
{
    [DbContext(typeof(EnterMovieContext))]
    [Migration("20230214072705_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("DateMe.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("SubmissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("SubmissionId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            SubmissionId = 1,
                            Category = "Action",
                            Director = "Christofer Nolan",
                            Edited = false,
                            LentTo = "",
                            Notes = "Favorite movie ever!",
                            Rating = "PG-13",
                            Title = "Inception",
                            Year = 2010
                        },
                        new
                        {
                            SubmissionId = 2,
                            Category = "Horror",
                            Director = "Mark Mylod",
                            Edited = false,
                            LentTo = "",
                            Notes = "Best movie recently.",
                            Rating = "R",
                            Title = "The Menu",
                            Year = 2022
                        },
                        new
                        {
                            SubmissionId = 3,
                            Category = "SciFi",
                            Director = "Gareth Edwards",
                            Edited = true,
                            LentTo = "",
                            Notes = "Best Star Wars movie.",
                            Rating = "PG-13",
                            Title = "Rogue One",
                            Year = 2016
                        });
                });
#pragma warning restore 612, 618
        }
    }
}