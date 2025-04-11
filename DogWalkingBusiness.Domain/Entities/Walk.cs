
namespace DogWalkingBusiness.Domain.Entities
{
    public class Walk
    {
        public int Id { get; set; }
        public int DogId { get; set; }
        public DateTime WalkDate { get; private set; }
        public TimeSpan Duration { get; private set; }

        public Dog Dog { get; set; }

        public Walk(int dogId, DateTime walkDate, TimeSpan duration)
        {          
            DogId = dogId;
            WalkDate = walkDate;
            Duration = duration;
        }
    }
}
