using Backlogmanager.DAL.DALs;
using Backlogmanager.DAL.DTOs;

namespace Backlogmanager.BLL
{
    
    public class UserContainer
    {
        private UserDAL _userDAL;
        
        public UserContainer()
        {
            _userDAL = new UserDAL();
        }

        public bool Add(User user)
        {
            UserDTO userDTO = ConvertToDTO(user);
            bool succes = _userDAL.Insert(userDTO);
            return succes;
        }

        private UserDTO ConvertToDTO(User user)
        {
            UserDTO dto = new UserDTO()
            {
                UserId = user.UserId,
                Username = user.Username,
                Email = user.Email,
                Points = user.Points,
                Password = user.Password
            };
            return dto;
        }
    }
}
