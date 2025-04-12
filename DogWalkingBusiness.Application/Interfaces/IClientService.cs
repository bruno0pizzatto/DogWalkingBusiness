using DogWalkingBusiness.Applications.DTOs;

namespace DogWalkingBusiness.Applications.Interfaces
{
    public interface IClientService
    {
        Task<IEnumerable<ClientDTO>> GetAllAsync();
        Task<ClientDTO> GetByIdAsync(int id);
        Task SaveAsync(ClientDTO client);        
        Task DeleteAsync(int id);
        Task<IEnumerable<ClientDTO>> SearchAsync(string keyword);
    }
}
