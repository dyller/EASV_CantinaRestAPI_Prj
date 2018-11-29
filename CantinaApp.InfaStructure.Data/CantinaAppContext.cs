﻿using CantinaApp.Core.Entity.Entities;
using CantinaApp.Core.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CantinaApp.InfaStructure.Data
{
    public class CantinaAppContext: DbContext
    {
        public CantinaAppContext(DbContextOptions<CantinaAppContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Main food can have many ingredients
            modelBuilder.Entity<MainFood>()
                .HasMany(p => p.Ingredients);
            //Main Food can have many allergens
            modelBuilder.Entity<MainFood>()
                .HasMany(a => a.Allergens);
            //Main Food can only have one Icon
            modelBuilder.Entity<MainFood>()
                .HasOne(a => a.FoodIconType);
            //Ingredientsd can only have one Icon
            modelBuilder.Entity<Ingredients>()
                .HasOne(a => a.FoodIconType);
            //Special Offers can only have one Icon
            modelBuilder.Entity<SpecialOffers>()
                .HasOne(a => a.FoodIconType);
            //Allergens can only have one Icon
            modelBuilder.Entity<Allergen>()
                .HasOne(a => a.FoodIconType);
            //Main food has PK ID and Ingredients
            modelBuilder.Entity<MainFood>()
                .HasKey(m => new { m.Id });

        }
        //Tables
        public DbSet<Users> User { get; set; }
        public DbSet<MainFood> MainFood { get; set; }
        public DbSet<FoodIcon> FoodIcon { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<Allergen> Allergen { get; set; }
        public DbSet<MOTD> MOTD { get; set; }
    }
}