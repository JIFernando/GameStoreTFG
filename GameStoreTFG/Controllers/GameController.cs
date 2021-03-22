using GameStoreTFG.Model;
using GameStoreTFG.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GameStoreTFG.Controllers
{
    public class GameController
    {
        private IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        // GET: api/<controller>
        [HttpGet]
        public List<GameModel> GetUsers()
        {
            return _gameService.GetGames();
        }

        // GET api/<controller>/5
        [HttpGet("{id}", Name = "GetUserInfo")]
        public GameModel Get(Guid id)
        {
            return _gameService.GetGameInfo(id);
        }

        // POST api/<controller>
        [HttpPost]
        public GameModel Post([FromBody]GameModel user)
        {
            return _gameService.AddGame(user);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public GameModel Put(Guid id, [FromBody]GameModel user)
        {
            return _gameService.UpdateGame(id, user);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return _gameService.DropGame(id);
        }

        // GET api/<controller>/5
        [HttpGet("{id}", Name = "GetUserInfo")]
        public List<GameModel> Serach(SearchGameModel filters)
        {
            return _gameService.SearchGames(filters);
        }
    }
}
