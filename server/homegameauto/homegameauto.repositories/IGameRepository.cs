using System;
using System.Collections.Generic;
using homegameauto.models;

namespace homegameauto.repositories
{
    public interface IGameRepository
    {
        IEnumerable<Game> GetAll();
        Game GetById(Guid id);
        IEnumerable<Game> GetByConsoleId(Guid consoleId);
    }
}
