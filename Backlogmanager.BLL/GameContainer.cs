using Backlogmanager.DAL.DALs;
using Backlogmanager.DAL.DTOs;
using System.Reflection.Metadata.Ecma335;

namespace Backlogmanager.BLL
{
    public class GameContainer
    {
        private GameDAL _gameDAL;

        public GameContainer()
        {
            _gameDAL = new GameDAL();
        }

        public bool Add(Game game)
        {
            GameDTO gameDTO = ConvertToDTO(game);
            bool succes = _gameDAL.Insert(gameDTO);
            return succes;
        }

        public List<Game> GetAll()
        {
            List<GameDTO> gameDTOs = _gameDAL.SelectAll();
            List<Game> output = new List<Game>();

            foreach (GameDTO dto in gameDTOs) 
            {
                Game game = new Game(dto.Name, dto.Platform, dto.Year_of_Release, dto.Genre, dto.Publisher, dto.User_Score);
                output.Add(game);
            }
            return output;
        }

        public Game GetById(Guid id)
        {
            GameDTO dto = _gameDAL.SelectById(id);
            Game game = new Game(dto.Name, dto.Platform, dto.Year_of_Release, dto.Genre, dto.Publisher, dto.User_Score);
            return game;
        }

        public bool Update(Game game)
        {
            GameDTO gameDTO = ConvertToDTO(game);
            bool succes = _gameDAL.Update(gameDTO);
            return succes;
        }

        public bool Delete(Guid id)
        {
            bool succes = _gameDAL.Delete(id);
            return succes;
        }

        private GameDTO ConvertToDTO(Game game)
        {
            GameDTO gameDTO = new GameDTO()
            {
                Name = game.Name,
                Platform = game.Platform,
                Year_of_Release = game.Year_of_Release,
                Genre = game.Genre,
                Publisher = game.Publisher,
                User_Score = game.User_Score,
                GameId = game.GameId
            };
            return gameDTO;
        }
    }
}
