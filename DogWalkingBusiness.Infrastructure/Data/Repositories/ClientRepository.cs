using DogWalkingBusiness.Application.DTOs;
using DogWalkingBusiness.Application.Interfaces;
using DogWalkingBusiness.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DogWalkingBusiness.Infrastructure.Data.Repositories
{
    public class ClientRepository : IClientService
    {
        private readonly DogWalkingDbContext _context;

        public ClientRepository(DogWalkingDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ClientDto>> GetAllClientsAsync()
        {
            return await _context.Clients
                .Select(c => new ClientDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    PhoneNumber = c.PhoneNumber
                }).ToListAsync();
        }

        public async Task<ClientDto> GetClientByIdAsync(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client == null) return null;

            return new ClientDto
            {
                Id = client.Id,
                Name = client.Name,
                PhoneNumber = client.PhoneNumber
            };
        }

        public async Task AddClientAsync(ClientDto clientDto)
        {
            var client = new Client(clientDto.Name, clientDto.PhoneNumber);
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateClientAsync(ClientDto clientDto)
        {
            var client = await _context.Clients.FindAsync(clientDto.Id);
            if (client != null)
            {
                client.Update(clientDto.Name, clientDto.PhoneNumber);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteClientAsync(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                await _context.SaveChangesAsync();
            }
        }
    }
}