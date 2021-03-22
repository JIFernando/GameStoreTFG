using GameStoreTFG.Data;
using GameStoreTFG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStoreTFG.Repository
{
    public interface IGameRepository
    {
        Games GetGameInfo(Guid id);
        List<Games> GetGames();
        Games AddGame(Games game);
        Games UpdateGame(Games game);
        bool DropGame(Guid id);
        List<Games> SearchGames(SearchGameModel filters);
    }
}
