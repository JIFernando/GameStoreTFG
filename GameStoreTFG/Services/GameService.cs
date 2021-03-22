using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GameStoreTFG.Data;
using GameStoreTFG.Model;
using GameStoreTFG.Repository;

namespace GameStoreTFG.Services
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;
        private readonly IMapper _mapper;

        public GameService(IGameRepository gameRepository, IMapper mapper)
        {
            _gameRepository = gameRepository;
            _mapper = mapper;
        }

        public GameModel AddGame(GameModel gameModel)
        {
            Games game = _gameRepository.AddGame(_mapper.Map<GameModel,Games>(gameModel));

            return _mapper.Map<Games, GameModel>(game);
        }

        public bool DropGame(Guid id)
        {
            return _gameRepository.DropGame(id);
        }

        public GameModel GetGameInfo(Guid id)
        {
            Games game = _gameRepository.GetGameInfo(id);

            return _mapper.Map<Games, GameModel>(game);
        }

        public List<GameModel> GetGames()
        {
            return _mapper.Map<List<Games>, List<GameModel>>(_gameRepository.GetGames());
        }

        public List<GameModel> SearchGames(SearchGameModel filters)
        {
            return _mapper.Map<List<Games>, List<GameModel>>(_gameRepository.SearchGames(filters));
        }

        public GameModel UpdateGame(Guid id, GameModel game)
        {
            Games g = _gameRepository.UpdateGame(_mapper.Map<GameModel, Games>(game));

            return _mapper.Map<Games, GameModel>(g);
        }
    }
}
