namespace Backlogmanager.ASP.Models
{
    public class UserVM
    {
        public Guid UserId { get; init; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public int Points { get; init; }
        public string? Password { get; set; }
    }
}
