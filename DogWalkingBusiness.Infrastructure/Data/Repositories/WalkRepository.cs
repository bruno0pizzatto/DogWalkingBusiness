using DogWalkingBusiness.Domain.Entities;
using DogWalkingBusiness.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace DogWalkingBusiness.Infrastructure.Data.Repositories
{
    public class WalkRepository : IWalkRepository
    {
        private readonly DogWalkingDbContext _context;

        public WalkRepository(DogWalkingDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Walk>> GetAllAsync()
        {
            return await _context.Walks.ToListAsync();
        }

        public async Task<IEnumerable<Walk>> GetByDogIdAsync(int dogId)
        {
            return await _context.Walks
                .Where(x =>
                    x.DogId == dogId
                ).ToListAsync();
        }

        public async Task<Walk> GetByIdAsync(int id)
        {
            var walk = await _context.Walks.FindAsync(id);
            if (walk == null) return null;

            return walk;
        }

        public async Task SaveAsync(Walk walk)
        {
            var walkExists = await _context.Walks.FindAsync(walk.Id);
            if (walkExists != null)
            {
                walkExists.Update(walk.DogId, walk.WalkDate, walk.Duration);
                _context.Walks.Update(walkExists);
                await _context.SaveChangesAsync();
            }
            else
            {
                _context.Walks.Add(walk);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            var walk = await _context.Walks.FindAsync(id);
            if (walk != null)
            {
                _context.Walks.Remove(walk);
                await _context.SaveChangesAsync();
            }
        }
    }
}
