using DogWalkingBusiness.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DogWalkingBusiness.Infrastructure.Data
{
    public class DogWalkingDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Walk> Walks { get; set; }

        public DogWalkingDbContext(DbContextOptions<DogWalkingDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany(c => c.Dogs)
                .WithOne(d => d.Client)
                .HasForeignKey(d => d.ClientId);

            modelBuilder.Entity<Dog>()
                .HasMany<Walk>()
                .WithOne(w => w.Dog)
                .HasForeignKey(w => w.DogId);
        }

    }
}
