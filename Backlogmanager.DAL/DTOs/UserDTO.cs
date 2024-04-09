namespace Backlogmanager.DAL.DTOs
{
    public class UserDTO
    {
        public Guid UserId { get; init; }
        public string ?Username { get; set; }
        public string ?Email { get; set;  }
        public int Points { get; init; }
        public string ?Password { get; set; }
    }
}
