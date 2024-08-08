namespace NorthHiking.API.Model.Domain
{
    public class Walk
    {
        public  Guid Id { get; set; }
        public string Name { get; set; }
        public string Deccriotion { get; set; }
        public double LengthInKM { get; set; }
        public String? WalkImgUrl  { get; set;}

        public Guid DifficultyID { get; set; }
        public Guid RegionID { get; set; }


        // Navigation Property

        public Difficulty Difficulty { get; set; }
        public Region Region { get; set; }



    }
}
