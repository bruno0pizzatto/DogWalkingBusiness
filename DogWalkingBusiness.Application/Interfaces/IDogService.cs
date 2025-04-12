using DogWalkingBusiness.Application.DTOs;

namespace DogWalkingBusiness.Application.Interfaces
{
    public interface IDogService
    {
        Task<IEnumerable<DogDTO>> GetAllAsync();
        Task<DogDTO> GetByIdAsync(int id);
        Task SaveAsync(DogDTO client);
        Task DeleteAsync(int id);
    }
}
