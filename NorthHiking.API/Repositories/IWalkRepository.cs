using NorthHiking.API.Model.Domain;

namespace NorthHiking.API.Repositories
{
    public interface IWalkRepository
    {
        Task<Walk> CreateAsync(Walk walk);
    }
}
