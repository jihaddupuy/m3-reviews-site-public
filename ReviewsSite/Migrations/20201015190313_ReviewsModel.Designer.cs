﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewsSite;

namespace ReviewsSite.Migrations
{
    [DbContext(typeof(DiningContext))]
    [Migration("20201015190313_ReviewsModel")]
    partial class ReviewsModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReviewsSite.Models.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Seafood",
                            Description = "Cleveland best seafood served on the best patio in town.",
                            Image = "",
                            Name = "Alley Cat Oyster Bar"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Asian BBQ",
                            Description = "Asian food grilled for you in front of you",
                            Image = "",
                            Name = "bd's Mongolian Grill"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Diner",
                            Description = "Upscale family restaurant",
                            Image = "",
                            Name = "Tommy's On Coventry"
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.Reviews", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Top notch food and setting,the staff was friendly and knowledgable about the variety of seafood.Highly recommended.",
                            RestaurantId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "One of my favorite places to go for good asian grilled food, highly recommended",
                            RestaurantId = 2
                        },
                        new
                        {
                            Id = 3,
                            Content = "By keeping its focus on balancing its menu between quality meat and vegetable entrees (and at an affordable price) Tommy's achieves its goal of creating  a watering hole where the carnivores and herbivores in your family can graze in peace.",
                            RestaurantId = 3
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.Reviews", b =>
                {
                    b.HasOne("ReviewsSite.Models.Restaurant", "Restaurant")
                        .WithMany("Reviews")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
