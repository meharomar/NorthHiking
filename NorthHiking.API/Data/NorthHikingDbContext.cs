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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Difficulties
            // Easy, Medium, hard

            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("3c40a4fb-b0c3-4cff-8484-3696bcc39062"),
                    Name = "Easy"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("09593e2e-fb49-4992-80a8-102e3880e1cf") ,
                    Name = "Medium"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("52dc5439-301a-40a2-8111-f5c4003be6f8"),
                    Name = "Hard"
                }

            };

            // This will seed data to the database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            // Seed data for Regions

            var regions = new List<Region>()
            {
                new Region()
                {
                    Id = new Guid("bf57edda-40cc-42e3-a1c6-650bd0899a63"),
                    Name = "Sawat",
                    Code = "swt",
                    RegionImgUrl = ".jpg"
                },
                new Region
                {
                    Id = Guid.Parse("f7248fc3-2585-4efb-8d1d-1c555f4087f6"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImgUrl = "https://images.pexels.com/photos/5169056/pexels-photo-5169056.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    Id = Guid.Parse("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"),
                    Name = "Northland",
                    Code = "NTL",
                    RegionImgUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("14ceba71-4b51-4777-9b17-46602cf66153"),
                    Name = "Bay Of Plenty",
                    Code = "BOP",
                    RegionImgUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("cfa06ed2-bf65-4b65-93ed-c9d286ddb0de"),
                    Name = "Wellington",
                    Code = "WGN",
                    RegionImgUrl = "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    Id = Guid.Parse("906cb139-415a-4bbb-a174-1a1faf9fb1f6"),
                    Name = "Nelson",
                    Code = "NSN",
                    RegionImgUrl = "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    Id = Guid.Parse("f077a22e-4248-4bf6-b564-c7cf4e250263"),
                    Name = "Southland",
                    Code = "STL",
                    RegionImgUrl = null
                },
            };

            modelBuilder.Entity<Region>().HasData(regions);
        
        }
    }
}
