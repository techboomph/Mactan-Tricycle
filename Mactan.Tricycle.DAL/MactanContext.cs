using System;
using Mactan.Tricycle.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Mactan.Tricycle.DAL
{
    public class MactanContext : DbContext
    {
        public MactanContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {       
        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<OwnerOrganization> OwnerOrganizations { get; set; }
        public DbSet<AssetDriver> AssetDrivers { get; set; }
        public DbSet<AuditHistory> AuditHistories { get; set; }
        public DbSet<Charge> Charges { get; set; }
        public DbSet<ChargeType> ChargeTypes { get; set; }
        public DbSet<MTUser> MTUsers { get; set; }
        public DbSet<PaymentTransaction> PaymentTransactions { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
    }
}
