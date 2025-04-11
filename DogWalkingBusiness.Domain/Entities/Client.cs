
namespace DogWalkingBusiness.Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
        public List<Dog> Dogs { get; private set; } = new List<Dog>();

        public Client(string name, string phoneNumber)
        {            
            Name = name;
            PhoneNumber = phoneNumber;
        }        
    }
}
