using DogWalkingBusiness.Domain.Entities;
using DogWalkingBusiness.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace DogWalkingBusiness.Infrastructure.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly DogWalkingDbContext _context;

        public ClientRepository(DogWalkingDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Client>> GetAllAsync()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task<Client> GetByIdAsync(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client == null) return null;

            return client;
        }

        public async Task SaveAsync(Client client)
        {
            var clientExists = await _context.Clients.FindAsync(client.Id);
            if (clientExists != null)
            {
                clientExists.Update(client.Name, client.PhoneNumber);
                _context.Clients.Update(clientExists);
                await _context.SaveChangesAsync();
            }
            else
            {               
                _context.Clients.Add(client);
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

        public async Task<IEnumerable<Client>> SearchAsync(string keyword)
        {
            return await _context.Clients
                .Where(x =>
                    x.Name.Contains(keyword)
                ).ToListAsync();
        }
    }
}