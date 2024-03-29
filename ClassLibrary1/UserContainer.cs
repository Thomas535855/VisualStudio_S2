using Backlogmanager.Business.DAL;
using Backlogmanager.Business.DTOs;
using BacklogManager.Domain;

namespace Backlogmanager.Domain
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

            UserDTO userDTO = new UserDTO() 
            {
                UserId = user.UserId,
                Username = user.Username,
                Email = user.Email,
                Points = user.Points,
                Password = user.Password,

            };

            bool succes = _userDAL.Insert(userDTO);
            return succes;
        }
    }
}
