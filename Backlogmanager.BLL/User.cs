namespace Backlogmanager.BLL
{
    public class User
    {
        public Guid UserId { get; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int Points { get; }
        public string Password { get; set; }

        public User(string username, string email, int points, string password)
        {
            UserId = Guid.NewGuid();
            Username = username;
            Email = email;
            Points = points;
            Password = password;
        }

        public User(Guid userId, string username, string email, int points, string password) 
        {
            UserId = userId;
            Username = username;
            Email = email;
            Points = points;
            Password = password;
        }
    }
}
