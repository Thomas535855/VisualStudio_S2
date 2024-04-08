namespace Backlogmanager.BLL
{
    public class Game
    {
        public string Name { get; set; }
        public string Platform { get; set; }
        public float Year_of_Release { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public float User_Score { get; set; }
        public Guid GameId { get; }

        public Game(string name, string platform, float year_of_release, string genre, string publisher, float user_score )
        {
            Name = name;
            Platform = platform;
            Year_of_Release = year_of_release;
            Genre = genre;
            Publisher = publisher;
            User_Score = user_score;
            GameId = Guid.NewGuid();
        }
    }
}
