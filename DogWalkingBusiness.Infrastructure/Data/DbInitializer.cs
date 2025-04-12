using DogWalkingBusiness.Domain.Entities;

namespace DogWalkingBusiness.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Seed(DogWalkingDbContext context)
        {
            if (context.Clients.Any()) return; // Already populated

            Client clientBruno = new Client("Bruno Pizzatto", "5511944787878");
            Client clientLarissa = new Client("Larissa Pizzatto", "5511944782323");

            context.Clients.Add(clientBruno);
            context.Clients.Add(clientLarissa);
            context.SaveChanges();

            clientBruno = context.Clients.Where(x => x.Name.Equals(clientBruno.Name)).FirstOrDefault();
            clientLarissa = context.Clients.Where(x => x.Name.Equals(clientLarissa.Name)).FirstOrDefault();

            Dog dogWhey = new Dog("Whey", "Lhasa", 7, clientBruno.Id);
            Dog dogPipoca = new Dog("Pipoca", "Cur", 4, clientBruno.Id);
            Dog dogBranca = new Dog("Branca", "Poodle", 14, clientBruno.Id);

            Dog dogYuka = new Dog("Yuka", "Yorkshire", 12, clientLarissa.Id);
            Dog dogJade = new Dog("Jade", "Yorkshire", 7, clientLarissa.Id);

            context.Dogs.Add(dogWhey);
            context.Dogs.Add(dogPipoca);
            context.Dogs.Add(dogBranca);

            context.Dogs.Add(dogYuka);
            context.Dogs.Add(dogJade);
            context.SaveChanges();

            dogWhey = context.Dogs.Where(x => x.Name.Equals(dogWhey.Name)).FirstOrDefault();
            dogPipoca = context.Dogs.Where(x => x.Name.Equals(dogPipoca.Name)).FirstOrDefault();
            dogBranca = context.Dogs.Where(x => x.Name.Equals(dogBranca.Name)).FirstOrDefault();

            var walk = new Walk(dogWhey.Id, DateTime.Now, TimeSpan.FromMinutes(30));
            var walk2 = new Walk(dogWhey.Id, DateTime.Now.AddDays(-2), TimeSpan.FromMinutes(30));
            var walk3 = new Walk(dogWhey.Id, DateTime.Now.AddDays(-1), TimeSpan.FromMinutes(30));

            var walk4 = new Walk(dogYuka.Id, DateTime.Now.AddDays(-1), TimeSpan.FromMinutes(30));
            var walk5 = new Walk(dogYuka.Id, DateTime.Now.AddDays(-3), TimeSpan.FromMinutes(30));
            var walk6 = new Walk(dogJade.Id, DateTime.Now.AddDays(-6), TimeSpan.FromMinutes(30));


            context.Walks.Add(walk);
            context.Walks.Add(walk2);
            context.Walks.Add(walk3);

            context.Walks.Add(walk4);
            context.Walks.Add(walk5);
            context.Walks.Add(walk6);

            context.SaveChanges();
        }
    }
}
