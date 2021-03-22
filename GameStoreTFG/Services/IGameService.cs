using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStoreTFG.Model;

namespace GameStoreTFG.Services
{
    public interface IGameService
    {
        GameModel GetGameInfo(Guid id);
        List<GameModel> GetGames();
        GameModel AddGame(GameModel user);
        GameModel UpdateGame(Guid id, GameModel user);
        bool DropGame(Guid id);
        List<GameModel> SearchGames(SearchGameModel filters);
    }
}
