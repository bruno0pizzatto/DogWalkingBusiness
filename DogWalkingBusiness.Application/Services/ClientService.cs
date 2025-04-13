using AutoMapper;
using DogWalkingBusiness.Applications.DTOs;
using DogWalkingBusiness.Applications.Interfaces;
using DogWalkingBusiness.Domain.Entities;
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

        public async Task SaveAsync(ClientDTO client)
        {
            await _clientRepository.SaveAsync(_mapper.Map<Client>(client)); 
        }
        
        public async Task DeleteAsync(int id)
        {
            await _clientRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ClientDTO>> SearchAsync(string keyword)
        {
            var clients = await _clientRepository.SearchAsync(keyword);
            return _mapper.Map<IEnumerable<ClientDTO>>(clients);
        }

    }
}
