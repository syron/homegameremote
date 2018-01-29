using System;
using System.Collections.Generic;
using homegameauto.models;

namespace homegameauto.repositories
{
    public interface IGameRepository
    {
        IList<Game> GetAll();
        Game GetById(Guid id);
        IList<Game> GetByConsoleId(Guid consoleId);
    }
}
