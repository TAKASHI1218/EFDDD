using EFDDD.Domain.Entities;
using EFDDD.Domain.ValueObjects;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDDD.Infrastructure.EFCore
{
    public class AndersonDBContext:DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ProductItemEntity> ProductItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(localdb)\MSSQLLocalDB";
            builder.InitialCatalog = "AndersonD";
            builder.IntegratedSecurity = true;
            optionsBuilder.UseSqlServer(builder.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEntity>().ToTable("Product");
            modelBuilder.Entity<ProductEntity>().HasKey(p => p.ProductId);
            modelBuilder.Entity<ProductEntity>().Property(p => p.ProductId).HasConversion(p => p.Value, p => new ProductId(p));
            modelBuilder.Entity<ProductEntity>().Property(p => p.Price).HasConversion(p => p.Value , p => new Price(p) );

            modelBuilder.Entity<ProductItemEntity>().ToTable("ProductItem");
            modelBuilder.Entity<ProductItemEntity>().HasKey(p => new { p.ProductId, p.ProductItemNo });
            modelBuilder.Entity<ProductItemEntity>().Property(p => p.ProductId).HasConversion(p => p.Value, p => new ProductId(p));

            modelBuilder.Entity<ProductItemEntity>()
                .HasOne(pi => pi.Product)
                .WithMany(p => p.ProductItems)
                .HasForeignKey(pi => pi.ProductId);
            
        }

    }
}
