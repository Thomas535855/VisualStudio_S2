namespace BacklogManager.Domain
{
    public class Game
    {
        public string Title {  get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        public Game(string title, DateTime releaseDate, string genre)
        {
            Title = title;
            ReleaseDate = releaseDate;
            Genre = genre;
        }

    }
}
