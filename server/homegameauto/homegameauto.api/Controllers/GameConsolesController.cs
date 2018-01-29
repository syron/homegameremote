using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using homegameauto.models;
using homegameauto.repositories;
using Microsoft.AspNetCore.Mvc;

namespace homegameauto.api.Controllers
{
    [Route("api/[controller]")]
    public class GameConsolesController : Controller
    {
        private readonly IGameConsoleRepository _gameConsoleRepository;

        public GameConsolesController(IGameConsoleRepository gameConsoleRepository)
        {
            _gameConsoleRepository = gameConsoleRepository;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<GameConsole> Get()
        {
            return _gameConsoleRepository.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public GameConsole Get(Guid id)
        {
            return _gameConsoleRepository.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
