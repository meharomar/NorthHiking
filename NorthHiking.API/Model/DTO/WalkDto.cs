namespace NorthHiking.API.Model.DTO
{
    public class WalkDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Deccriotion { get; set; }
        public double LengthInKM { get; set; }
        public String? WalkImgUrl { get; set; }

        public Guid DifficultyID { get; set; }
        public Guid RegionID { get; set; }
    }
}
