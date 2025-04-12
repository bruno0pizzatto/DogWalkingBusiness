namespace DogWalkingBusiness.Applications.DTOs
{
    public class WalkDTO
    {
        public int Id { get; set; }
        public int DogId { get; set; }
        public DateTime WalkDate { get; set; }
        public TimeSpan Duration { get; set; }

    }
}
