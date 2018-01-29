using System;
using System.Collections.Generic;
using homegameauto.models;

namespace homegameauto.repositories
{
    public class GameConsoleRepository : IGameConsoleRepository
    {
        public GameConsoleRepository()
        {
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IList<GameConsole> GetAll()
        {
            List<GameConsole> list = new List<GameConsole>();
            list.Add(new GameConsole() { Id = Guid.NewGuid(), Name = "XBox", Description = "Kalle kula....", IPAddress = "192.168.0.1" });
            list.Add(new GameConsole() { Id = Guid.NewGuid(), Name = "Playstation", Description = "Kalle kula....", IPAddress = "192.168.0.2" });
            list.Add(new GameConsole() { Id = Guid.NewGuid(), Name = "Gameboy", Description = "Kalle kula....", IPAddress = "192.168.0.3" });
            return list;
        }

        public GameConsole GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(GameConsole console)
        {
            throw new NotImplementedException();
        }

        public void Update(GameConsole console)
        {
            throw new NotImplementedException();
        }
    }
}
