using DogWalkingBusiness.Application.DTOs;

namespace DogWalkingBusiness.Application.Interfaces
{
    public interface IWalkService
    {
        Task<IEnumerable<WalkDTO>> GetAllAsync();
        Task<WalkDTO> GetByIdAsync(int id);
        Task SaveAsync(WalkDTO client);
        Task DeleteAsync(int id);
    }
}
