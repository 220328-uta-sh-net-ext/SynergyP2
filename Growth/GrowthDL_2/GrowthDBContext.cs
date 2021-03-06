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
        public DbSet<HealthProfile> HealthProfiles { get; set; } // table 2
        public DbSet<Goals> Goals { get; set; } // table 3
    }
}
