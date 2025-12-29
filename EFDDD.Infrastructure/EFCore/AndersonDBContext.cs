using EFDDD.Domain.Entities;
using EFDDD.Domain.ValueObjects;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDDD.Infrastructure.EFCore
{
    public class AndersonDBContext:DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ProductItemEntity> ProductItems { get; set; }
        public DbSet<LogEntity> Logs { get; set; }

        public AndersonDBContext(DbContextOptions<AndersonDBContext> options):base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ProductEntity
            modelBuilder.Entity<ProductEntity>().ToTable("Product");
            modelBuilder.Entity<ProductEntity>().HasKey(p => p.ProductId);
            modelBuilder.Entity<ProductEntity>().Property(p => p.ProductId).HasConversion(p => p.Value, p => new ProductId(p));
            modelBuilder.Entity<ProductEntity>().Property(p => p.Price).HasConversion(p => p.Value , p => new Price(p) );

            // ProductItemEntity
            modelBuilder.Entity<ProductItemEntity>().ToTable("ProductItem");
            modelBuilder.Entity<ProductItemEntity>().HasKey(p => new { p.ProductId, p.ProductItemNo });
            modelBuilder.Entity<ProductItemEntity>().Property(p => p.ProductId).HasConversion(p => p.Value, p => new ProductId(p));

            modelBuilder.Entity<ProductItemEntity>()
                .HasOne(pi => pi.Product)
                .WithMany(p => p.ProductItems)
                .HasForeignKey(pi => pi.ProductId);

            modelBuilder.Entity<ProductItemEntity>()
                .OwnsOne(p => p.GlobalPrice, g =>
                {
                    g.Property(p => p.Amount).HasColumnName("Amount");
                    g.Property(p => p.Currency).HasColumnName("Currency");
                    g.Property(p => p.Amount).HasPrecision(18, 2);
                });

            // LogEntity
            modelBuilder.Entity<LogEntity>().ToTable("Logs");
            modelBuilder.Entity<LogEntity>().HasKey(p => new { p.LogId });
            modelBuilder.Entity<LogEntity>().Property(p => p.LogId).HasConversion(p => p.Value, p => new LogId(p));
            modelBuilder.Entity<LogEntity>().Property(p => p.LogId).ValueGeneratedOnAdd();

            // マイグレーションでIdentityにしない場合
            //modelBuilder.Entity<LogEntity>().Property(p => p.LogId).ValueGeneratedNever();
        }

    }

    public class AndersonDbContextFactory : IDesignTimeDbContextFactory<AndersonDBContext>
    {
        public AndersonDBContext CreateDbContext(string[] args)
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(localdb)\MSSQLLocalDB";
            builder.InitialCatalog = "AndersonD2";
            builder.IntegratedSecurity = true;
            var o = new DbContextOptionsBuilder<AndersonDBContext>();
            o.UseSqlServer(builder.ConnectionString);
            return new AndersonDBContext(o.Options);
        }
    }
}
