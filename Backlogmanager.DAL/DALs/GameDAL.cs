using Backlogmanager.DAL.DTOs;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Backlogmanager.DAL.DALs
{
    public class GameDAL
    {
        string? connectionString = Environment.GetEnvironmentVariable("dbi535855");

        public bool Insert(GameDTO game)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                using SqlCommand command = new SqlCommand("Game_Insert", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Name", game.Name);
                command.Parameters.AddWithValue("@Platform", game.Platform);
                command.Parameters.AddWithValue("@Year_of_Release", game.Year_of_Release);
                command.Parameters.AddWithValue("@Genre", game.Genre);
                command.Parameters.AddWithValue("@Publisher", game.Publisher);
                command.Parameters.AddWithValue("@User_Score", game.User_Score);
                command.Parameters.AddWithValue("@GameId", game.GameId);

                conn.Open();
                int result = command.ExecuteNonQuery();
                return result == 1;
            }
            catch (SqlException) { return false; }
        }

        public List<GameDTO> SelectAll()
        {
            try
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                using SqlCommand command = new SqlCommand("Game_SelectAll", conn);
                command.CommandType = CommandType.StoredProcedure;

                List<GameDTO> output = new List<GameDTO>();
                conn.Open();
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    GameDTO gameDTO = ExtractDTO(reader);
                    output.Add(gameDTO);
                }
                return output;
            }
            catch (SqlException) { throw; }
        }

        public GameDTO SelectById(Guid id)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                using SqlCommand command = new SqlCommand("Game_SelectById", conn);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@GameId", id);

                conn.Open();
                using SqlDataReader reader = command.ExecuteReader();
                GameDTO gameDTO = new GameDTO();

                if (reader.Read())
                {
                    gameDTO = ExtractDTO(reader);

                }
                return gameDTO;
            }
            catch (SqlException) { throw; }
        }

        public bool Update(GameDTO gameDTO)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                using SqlCommand command = new SqlCommand("Game_Update", conn);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", gameDTO.Name);
                command.Parameters.AddWithValue("@Platform", gameDTO.Platform);
                command.Parameters.AddWithValue("@Year_of_Release", gameDTO.Year_of_Release);
                command.Parameters.AddWithValue("@Genre", gameDTO.Genre);
                command.Parameters.AddWithValue("@Publisher", gameDTO.Publisher);
                command.Parameters.AddWithValue("@User_Score", gameDTO.User_Score);
                command.Parameters.AddWithValue("@GameId", gameDTO.GameId);

                conn.Open();
                int result = command.ExecuteNonQuery();
                return result == 1;
            }
            catch (SqlException) { return false; }
        }

        public bool Delete(Guid id)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                using SqlCommand command = new SqlCommand("Game_Delete", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@GameId", id);

                conn.Open();
                int result = command.ExecuteNonQuery();
                return result == 1;
            }
            catch (SqlException) { throw; }
        }

        private GameDTO ExtractDTO(SqlDataReader reader) 
        {
            GameDTO gameDTO = new GameDTO()
            {
                Name = reader.GetString("Name"),
                Platform = reader.GetString("Platform"),
                Year_of_Release = (float)reader.GetDouble("Year_of_Release"),
                Genre = reader.GetString("Genre"),
                Publisher = reader.GetString("Publisher"),
                User_Score = (float)reader.GetDouble("User_Score"),
                GameId = reader.GetGuid("GameId")
            };
            return gameDTO;
        }

    }
}
