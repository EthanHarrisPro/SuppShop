using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SuppShop.Models;

namespace SuppShop.Data
{
    public class SuppShopContext : DbContext
    {
        public DbSet<CustomerM> Customers { get; set; } = null!;

        public DbSet<OrderM> Orders { get; set; } = null!;

        public DbSet<ProductM> Products { get; set; } = null!;

        public DbSet<OrderDetailsM> OrderDetails { get; set; } = null!;

        public DbSet<StaffM> Staff { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StaffM>()
                .HasIndex(s => s.Email)
                .IsUnique();
            modelBuilder.Entity<CustomerM>()
                .HasIndex(c => c.Email)
                .IsUnique();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SuppShop;");
        }
    }
}
