using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrsProofServer.Models {

    public class AppDbContext : DbContext {

        public AppDbContext(DbContextOptions<AppDbContext> context) : base(context) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            // unique index on User.Username
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();
            // unique index on Vendor.Code
            modelBuilder.Entity<Vendor>()
                .HasIndex(v => v.Code)
                .IsUnique();
            // unique index on Product.PartNumber
            modelBuilder.Entity<Product>()
                .HasIndex(p => p.PartNumber)
                .IsUnique();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestLine> RequestLines { get; set; }

    }
}
