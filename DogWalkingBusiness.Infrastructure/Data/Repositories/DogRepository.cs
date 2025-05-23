﻿using DogWalkingBusiness.Domain.Entities;
using DogWalkingBusiness.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace DogWalkingBusiness.Infrastructure.Data.Repositories
{
    public class DogRepository : IDogRepository
    {
        private readonly DogWalkingDbContext _context;

        public DogRepository(DogWalkingDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Dog>> GetAllAsync()
        {
            return await _context.Dogs.ToListAsync();
        }

        public IQueryable<Dog> GetByClientIdAsync(int clientId)
        {
            return _context.Dogs.Where(x =>
                    x.ClientId == clientId
                ).AsQueryable(); 
        }

        public async Task<Dog> GetByIdAsync(int id)
        {
            var dog = await _context.Dogs.FindAsync(id);
            if (dog == null) return null;

            return dog;
        }

        public async Task SaveAsync(Dog dog)
        {
            var dogExists = await _context.Dogs.FindAsync(dog.Id);
            if (dogExists != null)
            {
                dogExists.Update(dog.Name, dog.Breed, dog.Age, dog.ClientId);
                _context.Update(dogExists);
                await _context.SaveChangesAsync();
            }
            else
            {
                _context.Dogs.Add(dog);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            var dog = await _context.Dogs.FindAsync(id);
            if (dog != null)
            {
                _context.Dogs.Remove(dog);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Dog>> SearchAsync(string keyword)
        {
            return await _context.Dogs
                .Where(x =>
                    x.Name.Contains(keyword)
                ).ToListAsync();
        }
    }
}
