using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using WarehouseRemittance.App.Applications;
using WarehouseRemittance.App.Domain.Entities.Products;
using WarehouseRemittance.App.Domain.Entities.RemittanceOrder;
using WarehouseRemittance.App.Domain.Entities.Users;
using WarehouseRemittance.App.Domain.Entities.Warehouses;

namespace WarehouseRemittance.App.Data.Context
{
    // Add-Migration 001 -OutputDir "Data/Migrations"
    public class WarehouseRemittanceContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server={Values.ServerIp};Database={Values.DatabaseName};Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Order>()
                .HasOne(e => e.Warehouse)
                .WithMany(c => c.Orders)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder
                .Entity<OrderDetail>()
                .HasOne(e => e.Product)
                .WithMany(c => c.OrderDetails)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<ProductGroup>()
                .HasData(new List<ProductGroup>
                {
                    new ProductGroup{Id = 1, Name = "تایتان و پلی فیکس و ویتو" },
                    new ProductGroup{Id = 2, Name = "استارباند و آرازیم و شارک"},
                    new ProductGroup{Id = 3, Name = "چسب های نواری و کاغذی"},
                });
        }
    }
}
