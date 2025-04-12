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

        public async Task<IEnumerable<ClientDTO>> GetAllAsync()
        {
            return await _context.Clients
                .Select(c => new ClientDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                    PhoneNumber = c.PhoneNumber
                }).ToListAsync();
        }

        public async Task<ClientDTO> GetByIdAsync(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client == null) return null;

            return new ClientDTO
            {
                Id = client.Id,
                Name = client.Name,
                PhoneNumber = client.PhoneNumber
            };
        }

        public async Task SaveAsync(ClientDTO clientDto)
        {
            var client = await _context.Clients.FindAsync(clientDto.Id);
            if (client != null)
            {
                client.Update(clientDto.Name, clientDto.PhoneNumber);
                await _context.SaveChangesAsync();
            }
            else
            {
                var clientNew = new Client(clientDto.Name, clientDto.PhoneNumber);
                _context.Clients.Add(clientNew);
                await _context.SaveChangesAsync();
            }
        }      

        public async Task DeleteAsync(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<ClientDTO>> SearchAsync(string keyword)
        {
            return await _context.Clients
                .Where(x =>
                    x.Name.Contains(keyword)
                )
                .Select(c => new ClientDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                    PhoneNumber = c.PhoneNumber
                }).ToListAsync();
        }
    }
}