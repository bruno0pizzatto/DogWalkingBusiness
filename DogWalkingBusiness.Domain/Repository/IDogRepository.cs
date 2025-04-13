using DogWalkingBusiness.Domain.Entities;

namespace DogWalkingBusiness.Domain.Repository
{
    public interface IDogRepository
    {
        Task<IEnumerable<Dog>> GetAllAsync();
        Task<IEnumerable<Dog>> GetByClientIdAsync(int clientId);
        Task<Dog> GetByIdAsync(int id);
        Task SaveAsync(Dog dog);
        Task DeleteAsync(int id);
        Task<IEnumerable<Client>> SearchAsync(string keyword);
    }
}
