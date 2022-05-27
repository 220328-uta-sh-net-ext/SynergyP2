using GrowthModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GrowthDL
{
    public class GrowthDBContext : DbContext
    {
        public GrowthDBContext() : base()
        {
        }
        public GrowthDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UserAccount> Users { get; set; } //table 1

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API
            modelBuilder.Entity<UserAccount>()
                .Property(u => u.Username)
                .HasColumnName("username")
                .ValueGeneratedOnAdd();
        }
    }
}
