using EFDDD.Domain.Entities;
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
        }

    }
}
