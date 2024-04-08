namespace Backlogmanager.DAL.DTOs
{
    public class GameDTO
    {
        public string Name { get; set; }
        public string Platform { get; set; }
        public float Year_of_Release { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public float User_Score { get; set; }
        public Guid GameId { get; set; }
    }
}
