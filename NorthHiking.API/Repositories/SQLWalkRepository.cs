using Microsoft.EntityFrameworkCore;
using NorthHiking.API.Data;
using NorthHiking.API.Model.Domain;

namespace NorthHiking.API.Repositories
{
    public class SQLWalkRepository : IWalkRepository
    {
        private readonly NorthHikingDbContext dbContext;

        public SQLWalkRepository(NorthHikingDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Walk> CreateAsync(Walk walk)
        {
            await dbContext.Walks.AddAsync(walk);
            await dbContext.SaveChangesAsync();
            return walk;
        }
    }
}
