﻿using Microsoft.EntityFrameworkCore;
using NorthHiking.API.Data;
using NorthHiking.API.Model.Domain;

namespace NorthHiking.API.Repositories
{
    public class SQLRegionRepository : IRegionRepository
    {
        private readonly NorthHikingDbContext dbContext;
        public SQLRegionRepository(NorthHikingDbContext dbContext) 
        { 
            this.dbContext = dbContext;
        }

        public async Task<Region> CreateAsync(Region region)
        {
             await dbContext.Regions.AddAsync(region);
             await dbContext.SaveChangesAsync();
            return region;
        }

        public async Task<Region?> DeleteAsync(Guid id)
        {
            var existingRegion = await dbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
            if (existingRegion == null)
            {
                return null;
            }

            dbContext.Remove(existingRegion);
            await dbContext.SaveChangesAsync();
            return existingRegion;

        }

        public async Task<List<Region>> GetAllAsync()
        {
           return await dbContext.Regions.ToListAsync();
        }

        public async Task<Region?> GetByIdAsync(Guid id)
        {
            return await dbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Region?> UpdateAsync(Guid id, Region region)
        {
            var existingRegion = await dbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
            if (existingRegion == null)
            {
                return null;
            }

            existingRegion.Code= region.Code;
            existingRegion.Name= region.Name;
            existingRegion.RegionImgUrl= region.RegionImgUrl;

            await dbContext.SaveChangesAsync();
            return existingRegion;
                }
    }
}
