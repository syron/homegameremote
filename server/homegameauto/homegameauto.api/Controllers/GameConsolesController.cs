﻿using System;
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
        private readonly IGameConsoleRepository _gameConsoleRepositories;

        public GameConsolesController(IGameConsoleRepository gameConsoleRepositories)
        {
            _gameConsoleRepositories = gameConsoleRepositories;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<GameConsole> Get()
        {
            return _gameConsoleRepositories.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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