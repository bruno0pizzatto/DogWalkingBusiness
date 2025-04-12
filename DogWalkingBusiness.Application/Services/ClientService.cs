using AutoMapper;
using DogWalkingBusiness.Applications.DTOs;
using DogWalkingBusiness.Applications.Interfaces;
using DogWalkingBusiness.Domain.Repository;

namespace DogWalkingBusiness.Applications.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public ClientService(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ClientDTO>> GetAllAsync()
        {
            var clients = await _clientRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ClientDTO>>(clients);
        }
    }
}
