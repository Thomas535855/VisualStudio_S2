namespace BacklogManager.Domain
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Points { get; set; }


        public User(Guid userId, string username, string email, string password, int points) 
        { 
            UserId = userId;
            Username = username;
            Email = email;
            Password = password;
            Points = points;
        }
    }
}
