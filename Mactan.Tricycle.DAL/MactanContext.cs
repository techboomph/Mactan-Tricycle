using System;
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
    }
}
