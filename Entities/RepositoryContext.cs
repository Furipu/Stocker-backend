using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<PostCity> PostCities { get; set; }
        public DbSet<PriceHistory> priceHistories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductVersion> ProductVersions { get; set; }
        public DbSet<Quality> Qualities { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adress>().ToTable("Adress");
            modelBuilder.Entity<Brand>().ToTable("Brand");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Country>().ToTable("Country");
            modelBuilder.Entity<Location>().ToTable("Location");
            modelBuilder.Entity<PostCity>().ToTable("PostCity");
            modelBuilder.Entity<PriceHistory>().ToTable("PriceHistory");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<ProductVersion>().ToTable("ProductVersion");
            modelBuilder.Entity<Quality>().ToTable("Quality");
            modelBuilder.Entity<Status>().ToTable("Status");
            modelBuilder.Entity<Supplier>().ToTable("Supplier");

            modelBuilder.Entity<Adress>()
                .HasOne(a => a.Brand)
                .WithOne(b => b.Adress)
                .HasForeignKey<Brand>(b => b.AdressId);

            modelBuilder.Entity<Adress>()
                .HasOne(a => a.Supplier)
                .WithOne(b => b.Adress)
                .HasForeignKey<Supplier>(b => b.AdressId);

            modelBuilder.Entity<Status>().HasData(
                new Status { Id = 1, StatusName = "ok" },
                new Status { Id = 2, StatusName = "Niet Ok" });

            

            
        }
    }
}
