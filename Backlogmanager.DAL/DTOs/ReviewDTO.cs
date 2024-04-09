namespace Backlogmanager.DAL.DTOs
{
    public class ReviewDTO
    {
        public Guid ReviewId { get; }
        public Guid GameId { get; }
        public int Rating { get; set; }
        public string Description { get; set; }
    }
}
