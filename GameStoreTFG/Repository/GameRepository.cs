using GameStoreTFG.Context;
using GameStoreTFG.Data;
using GameStoreTFG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStoreTFG.Repository
{
    public class GameRepository : IGameRepository
    {
        private readonly AppDbContext _context;

        public GameRepository(AppDbContext context)
        {
            _context = context;
        }

        public Games GetGameInfo(Guid id)
        {
            return _context.Games.Find(id);
        }

        public List<Games> GetGames()
        {
            return _context.Games.ToList();
        }

        public Games AddGame(Games game)
        {
            _context.Games.Add(game);
            _context.SaveChanges();

            return game;
        }

        public Games UpdateGame(Games game)
        {
            _context.Games.Update(game);
            _context.SaveChanges();

            return game;
        }

        public bool DropGame(Guid id)
        {
            bool result = false;
            Games g = _context.Games.Find(id);

            if (g != null)
            {
                _context.Games.Remove(g);
                _context.SaveChanges();
                result = true;
            }

            return result;
        }

        public List<Games> SearchGames(SearchGameModel filters)
        {
            return _context.Games.Where(g =>
                    g.name.Contains(filters.gameName)
                    && (g.publishDate >= DateTime.Now || filters.isPublish)
                    && (filters.categories == null || (filters.categories != null && g.Categories.Union(filters.categories).Where(w => !(g.Categories.Contains(w) && filters.categories.Contains(w))).Any()))).ToList();
        }
    }
}
