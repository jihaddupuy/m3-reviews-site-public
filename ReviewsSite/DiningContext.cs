﻿using Microsoft.EntityFrameworkCore;
using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite
{
    public class DiningContext : DbContext 
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=DiningDB;Trusted_Connection=True";

            optionsBuilder.UseSqlServer(connectionString)
            .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant()
                {
                    Id = 1,
                    Name = "Alley Cat Oyster Bar",
                    Category = "Seafood",
                    Description = "Cleveland best seafood served on the best patio in town.",
                    Review = "Top notch food and setting,the staff was friendly and knowledgable about the variety of seafood.Highly recommended.",
                    Image =  ""

                },

                new Restaurant
                {
                    Id = 2,
                    Name = "bd's Mongolian Grill",
                    Category = "Asian BBQ",
                    Description = "Asian food grilled for you in front of you",
                    Review = "One of my favorite places to go for good asian grilled food, highly recommend",
                    Image = ""
                },

                new Restaurant
                {
                    Id = 3,
                    Name = "Tommy's On Coventry",
                    Category = "Diner",
                    Description = "Upscale family restaurant",
                    Review = "By keeping its focus on balancing its menu between quality meat and vegetable entrees (and at an affordable price) Tommy's achieves its goal of creating  a watering hole where the carnivores and herbivores in your family can graze in peace.",
                    Image = ""
                    
                });

            modelBuilder.Entity<Reviews>().HasData(
                new Reviews()
                {
                    Id = 1,
                    Name = "Brian"
                },


                new Reviews()
                {
                    Id = 2,
                    Name = "Jihad"
                },

                new Reviews()
                {
                    Id = 3,
                    Name = "Hugh"
                }

                );

            base.OnModelCreating(modelBuilder);
                
        }

    }
}
