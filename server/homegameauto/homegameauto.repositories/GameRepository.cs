using System;
using System.Collections.Generic;
using homegameauto.models;

namespace homegameauto.repositories
{
    public class GameRepository : IGameRepository
    {
        public GameRepository()
        {
        }

        public IList<Game> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<Game> GetByConsoleId(Guid consoleId)
        {
            throw new NotImplementedException();
        }

        public Game GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
