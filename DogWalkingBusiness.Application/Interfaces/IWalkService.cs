using DogWalkingBusiness.Applications.DTOs;

namespace DogWalkingBusiness.Applications.Interfaces
{
    public interface IWalkService
    {
        Task<IEnumerable<WalkDTO>> GetAllAsync();
        //Task<WalkDTO> GetByIdAsync(int id);
        //Task SaveAsync(WalkDTO client);
        //Task DeleteAsync(int id);
    }
}
