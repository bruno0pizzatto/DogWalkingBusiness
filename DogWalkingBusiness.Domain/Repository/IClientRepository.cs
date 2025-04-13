using DogWalkingBusiness.Domain.Entities;

namespace DogWalkingBusiness.Domain.Repository
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAllAsync();
        Task<Client> GetByIdAsync(int id);
        Task SaveAsync(Client client);        
        Task DeleteAsync(int id);
        Task<IEnumerable<Client>> SearchAsync(string keyword);
    }
}
