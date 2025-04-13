using DogWalkingBusiness.Domain.Entities;

namespace DogWalkingBusiness.Domain.Repository
{
    public interface IDogRepository
    {
        Task<IEnumerable<Dog>> GetAllAsync();
        IQueryable<Dog> GetByClientIdAsync(int clientId);
        Task<Dog> GetByIdAsync(int id);
        Task SaveAsync(Dog dog);
        Task DeleteAsync(int id);
        Task<IEnumerable<Dog>> SearchAsync(string keyword);
    }
}
