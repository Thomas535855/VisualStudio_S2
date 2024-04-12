namespace Backlogmanager.ASP.Models
{
    public class ReviewVM
    {
        public Guid ReviewId { get; }
        public Guid GameId { get; }
        public int Rating { get; set; }
        public string Description { get; set; }
    }
}
