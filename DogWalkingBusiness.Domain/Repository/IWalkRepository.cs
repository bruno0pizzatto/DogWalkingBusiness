using DogWalkingBusiness.Domain.Entities;

namespace DogWalkingBusiness.Domain.Repository
{
    public interface IWalkRepository
    {
        Task<IEnumerable<Walk>> GetAllAsync();
        Task<IEnumerable<Walk>> GetDogIdAsync(int dogId);
        Task<Walk> GetByIdAsync(int id);
        Task SaveAsync(Walk walk);
        Task DeleteAsync(int id);
    }
}
