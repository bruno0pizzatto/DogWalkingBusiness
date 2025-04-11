using DogWalkingBusiness.Application.DTOs;

namespace DogWalkingBusiness.Application.Interfaces
{
    public interface IClientService
    {
        Task<IEnumerable<ClientDto>> GetAllClientsAsync();
        Task<ClientDto> GetClientByIdAsync(int id);
        Task AddClientAsync(ClientDto client);
        Task UpdateClientAsync(ClientDto client);
        Task DeleteClientAsync(int id);
    }
}
