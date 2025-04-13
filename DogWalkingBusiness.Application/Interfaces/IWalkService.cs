using DogWalkingBusiness.Applications.DTOs;

namespace DogWalkingBusiness.Applications.Interfaces
{
    public interface IWalkService
    {
        Task<IEnumerable<WalkDTO>> GetAllAsync();
        Task<WalkDTO> GetByIdAsync(int id);
        Task<IEnumerable<WalkDTO>> GetByDogIdAsync(int dogId);
        Task SaveAsync(WalkDTO walk);
        Task DeleteAsync(int id);
    }
}
