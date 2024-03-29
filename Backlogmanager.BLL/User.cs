namespace Backlogmanager.BLL
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int Points { get; set; }
        public string Password { get; set; }

        public User(string username, string email, int points, string password)
        {
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
