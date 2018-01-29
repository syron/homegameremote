using System;
using System.Collections.Generic;
using homegameauto.models;

namespace homegameauto.repositories
{
    public interface IGameConsoleRepository
    {
        IList<GameConsole> GetAll();
        GameConsole GetById(Guid id);
        void Insert(GameConsole console);
        void Delete(Guid id);
        void Update(GameConsole console);
    }
}