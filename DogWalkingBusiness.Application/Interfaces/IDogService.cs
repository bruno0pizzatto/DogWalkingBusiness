using DogWalkingBusiness.Applications.DTOs;

namespace DogWalkingBusiness.Applications.Interfaces
{
    public interface IDogService
    {
        Task<IEnumerable<DogDTO>> GetAllAsync();
        //Task<DogDTO> GetByIdAsync(int id);
        //Task SaveAsync(DogDTO client);
        //Task DeleteAsync(int id);
    }
}
