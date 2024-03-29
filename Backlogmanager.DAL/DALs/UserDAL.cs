using Backlogmanager.DAL.DTOs;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Backlogmanager.DAL.DALs
{
    public class UserDAL
    {
        public UserDAL() { }

        string? connectionString = Environment.GetEnvironmentVariable("dbi535855");

        public bool Insert(UserDTO user)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                using SqlCommand command = new("User_Insert", conn);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserId", user.UserId);
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Points", user.Points);
                command.Parameters.AddWithValue("@Password", user.Password);

                conn.Open();
                int result = command.ExecuteNonQuery();
                return result == 1;
            }
            catch (SqlException) { return false; }
        }
    }
}
