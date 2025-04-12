using DogWalkingBusiness.Domain.Entities;

namespace DogWalkingBusiness.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Seed(DogWalkingDbContext context)
        {
            if (context.Clients.Any()) return; // Already populated

            Client clientBruno = new Client("Bruno Pizzatto", "5511944787878");

            context.Clients.Add(clientBruno);

            clientBruno = context.Clients.Where(x => x.Name.Equals(clientBruno.Name)).FirstOrDefault();

            Dog dogWhey = new Dog("Whey", "Lhasa", 3, clientBruno.Id);
            Dog dogPipoca = new Dog("Pipoca", "Cur", 3, clientBruno.Id);
            Dog dogBranca = new Dog("Branca", "Poodle", 3, clientBruno.Id);

            context.Dogs.Add(dogWhey);
            context.Dogs.Add(dogPipoca);
            context.Dogs.Add(dogBranca);

            dogWhey = context.Dogs.Where(x => x.Name.Equals(dogWhey.Name)).FirstOrDefault();
            dogPipoca = context.Dogs.Where(x => x.Name.Equals(dogPipoca.Name)).FirstOrDefault();
            dogBranca = context.Dogs.Where(x => x.Name.Equals(dogBranca.Name)).FirstOrDefault();

            var walk = new Walk(dogWhey.Id, DateTime.Now, TimeSpan.FromMinutes(30));
            var walk2 = new Walk(dogWhey.Id, DateTime.Now.AddDays(-2), TimeSpan.FromMinutes(30));
            var walk3 = new Walk(dogWhey.Id, DateTime.Now.AddDays(-1), TimeSpan.FromMinutes(30));


            context.Walks.Add(walk);
            context.Walks.Add(walk2);
            context.Walks.Add(walk3);

            context.SaveChanges();
        }
    }
}
