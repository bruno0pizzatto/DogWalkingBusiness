
namespace DogWalkingBusiness.Domain.Entities
{
    public class Dog
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Name { get; private set; }
        public string Breed { get; private set; }
        public int Age { get; private set; }

        public Client Client { get; set; }

        public Dog(string name, string breed, int age, int clientId)
        {            
            Name = name;
            Breed = breed;
            Age = age;
            ClientId = clientId;
        }
    }
}
