using AutoMapper;
using DogWalkingBusiness.Applications.DTOs;
using DogWalkingBusiness.Applications.Interfaces;
using DogWalkingBusiness.Domain.Entities;
using DogWalkingBusiness.Domain.Repository;

namespace DogWalkingBusiness.Applications.Services
{
    public class WalkService : IWalkService
    {
        private readonly IWalkRepository _walkRepository;
        private readonly IMapper _mapper;

        public WalkService(IWalkRepository walkRepository, IMapper mapper)
        {
            _walkRepository = walkRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<WalkDTO>> GetAllAsync()
        {
            var walks = await _walkRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<WalkDTO>>(walks);
        }

        public async Task<WalkDTO> GetByIdAsync(int id)
        {
            var walk = await _walkRepository.GetByIdAsync(id);
            return _mapper.Map<WalkDTO>(walk);
        }

        public async Task<IEnumerable<WalkDTO>> GetByDogIdAsync(int dogId)
        {
            var walks = await _walkRepository.GetByDogIdAsync(dogId);
            return _mapper.Map<IEnumerable<WalkDTO>>(walks);
        }

        public async Task SaveAsync(WalkDTO walk)
        {
            await _walkRepository.SaveAsync(_mapper.Map<Walk>(walk));
        }

        public async Task DeleteAsync(int id)
        {
            await _walkRepository.DeleteAsync(id);
        }            
    }
}
