using AutoMapper;
using DogWalkingBusiness.Applications.DTOs;
using DogWalkingBusiness.Applications.Interfaces;
using DogWalkingBusiness.Domain.Entities;
using DogWalkingBusiness.Domain.Repository;

namespace DogWalkingBusiness.Applications.Services
{
    public class DogService : IDogService
    {
        private readonly IDogRepository _dogRepository;
        private readonly IMapper _mapper;

        public DogService(IDogRepository dogRepository, IMapper mapper)
        {
            _dogRepository = dogRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DogDTO>> GetAllAsync()
        {
            var dogs = await _dogRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<DogDTO>>(dogs);
        }
        
        public IEnumerable<DogDTO> GetByClientIdAsync(int clientId)
        {
            var dogs = _dogRepository.GetByClientIdAsync(clientId);
            return _mapper.Map<IEnumerable<DogDTO>>(dogs);
        }

        public async Task<DogDTO> GetByIdAsync(int id)
        {
            var dog = await _dogRepository.GetByIdAsync(id);
            return _mapper.Map<DogDTO>(dog);
        }

        public async Task SaveAsync(DogDTO dog)
        {
            await _dogRepository.SaveAsync(_mapper.Map<Dog>(dog));
        }

        public async Task DeleteAsync(int id)
        {
            await _dogRepository.DeleteAsync(id);
        }
    }
}
