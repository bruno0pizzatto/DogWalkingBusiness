using DogWalkingBusiness.Applications.DTOs;

namespace DogWalkingBusiness.Applications.Interfaces
{
    public interface IDogService
    {
        Task<IEnumerable<DogDTO>> GetAllAsync();
        IEnumerable<DogDTO> GetByClientIdAsync(int clientId);
        Task<DogDTO> GetByIdAsync(int id);
        Task SaveAsync(DogDTO dog);
        Task DeleteAsync(int id);
    }
}
