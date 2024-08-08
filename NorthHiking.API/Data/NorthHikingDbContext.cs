using Microsoft.EntityFrameworkCore;
using NorthHiking.API.Model.Domain;

namespace NorthHiking.API.Data
{
    public class NorthHikingDbContext : DbContext
    {
        public NorthHikingDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
                
        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
    }
}
