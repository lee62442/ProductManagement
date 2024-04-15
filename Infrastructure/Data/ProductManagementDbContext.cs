using System;
using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace Infrastructure.Data
{
	public class ProductManagementDbContext : DbContext
	{
        // Configure options to communicate with the DB
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("/Users/lee62442/Projects/ProductManagement/ProductManagement/appsettings.json")
                    .Build();
                var connectionString = configuration.GetConnectionString("ProductManagementDbConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }


        public DbSet<Product> Products { get; set; }

        public DbSet<ApprovalRequest> ApprovalRequests { get; set; }

        // Generate Dummy Data for Tables
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            DummyDataGenerator generator = new DummyDataGenerator();
            generator.GenerateDummyData(10); // Generate 10 dummy products and put in approval queue

            // Generate dummy products
            List<Product> dummyProducts = generator.GetDummyProducts(); // Get dummy products

            // Generate dummy approval queue data
            List<ApprovalRequest> dummyApprovalQueue = generator.GetDummyApprovalQueue(); // Get dummy approval requests/queue

            // Seed initial data when migrating or creating the database
            modelBuilder.Entity<Product>().HasData(dummyProducts);
            modelBuilder.Entity<ApprovalRequest>().HasData(dummyApprovalQueue);
        }

    }
}

