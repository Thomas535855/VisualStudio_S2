namespace BacklogManager.Domain
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }

        public Review(int reviewId, int rating, string description) 
        {
            ReviewId = reviewId;
            Rating = rating;
            Description = description;
        }
    }
}
