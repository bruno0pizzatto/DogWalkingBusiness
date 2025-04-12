using DogWalkingBusiness.Application.DTOs;

namespace DogWalkingBusiness.Application.Interfaces
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
