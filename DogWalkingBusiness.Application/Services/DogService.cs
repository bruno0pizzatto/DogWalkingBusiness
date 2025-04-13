using AutoMapper;
using DogWalkingBusiness.Applications.DTOs;
using DogWalkingBusiness.Applications.Interfaces;
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
    }
}
