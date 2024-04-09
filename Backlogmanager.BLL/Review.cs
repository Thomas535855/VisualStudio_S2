namespace Backlogmanager.BLL
{
    public class Review
    {
        public Guid ReviewId { get; }
        public Guid GameId { get; }
        public int Rating { get; set; }
        public string Description { get; set; }

        public Review(int rating, string description)
        {
            Rating = rating;
            Description = description;
        }

        public Review(Guid reviewId, Guid gameId, int rating, string description)
        {
            ReviewId = reviewId;
            GameId = gameId;
            Rating = rating;
            Description = description;
        }
    }
}
