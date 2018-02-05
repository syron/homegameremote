using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using homegameauto.api.Models;
using homegameauto.models;
using homegameauto.repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace homegameauto.api.Controllers
{
    [Route("api/[controller]")]
    public class GamesController : Controller
    {
        private readonly IGameRepository _gameRepository;
        private readonly IGameConsoleRepository _gameConsoleRepository;

        public GamesController(IGameRepository gameRepository, IGameConsoleRepository gameConsoleRepository) 
        {
            _gameRepository = gameRepository;
            _gameConsoleRepository = gameConsoleRepository;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Game> Get(Guid? consoleId = null)
        {
            if (consoleId.HasValue)
                return _gameRepository.GetByConsoleId(consoleId.Value);
            
            return _gameRepository.GetAll();
        }

        // POST: api/games/{id}/start
        [HttpGet("{id}/start")]
        public StartGameStatus Start(Guid id) {
            // command
            // 1. Get Game by Id
            // 2. get ip address of gameconsole

            var game = _gameRepository.GetById(id);
            var gameConsole = _gameConsoleRepository.GetById(game.ConsoleId);

            var command = string.Format("triforcetools.py {0} {1}", gameConsole.IPAddress, game.Name);


            StartGameStatus status = new StartGameStatus();

            Random rand = new Random();
            if (rand.Next(0, 2) == 0)
            {
                status.Status = false;
                status.Message = "Game did not start... Do not know why, but I guess it's your fault!";
                return status;
            }
            status.Status = true;
            status.Message = "Game started...";

            return status;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Game Get(Guid id)
        {
            return _gameRepository.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Game game)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]Game game)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
        }
    }
}
