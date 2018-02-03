using System;
using System.Collections.Generic;
using System.Linq;
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
            list.Add(new GameConsole() { Id = Guid.Parse("01bbd4d6-85a1-4a5b-8f11-29d5fb321143"), Name = "XBox", Description = "Kalle kula....", IPAddress = "192.168.0.1", ImageUrl = new Uri("http://www.impulsegamer.com/articles/wp-content/uploads/2017/11/xboxonexconsole.jpg")  });
            list.Add(new GameConsole() { Id = Guid.Parse("d9bdbb8b-64b8-40bb-b3f9-8830acba6313"), Name = "Playstation", Description = "Kalle kula....", IPAddress = "192.168.0.2", ImageUrl = new Uri("https://images-na.ssl-images-amazon.com/images/I/71esByYMVHL._SL1500_.jpg") });
            list.Add(new GameConsole() { Id = Guid.Parse("dc8ed7d5-344d-4d51-8b8a-4b8a10d94c3f"), Name = "Gameboy", Description = "Kalle kula....", IPAddress = "192.168.0.3", ImageUrl = new Uri("http://www.denofgeek.us/sites/denofgeekus/files/styles/main_wide/public/5/08/game_boy.jpg") });
            return list;
        }

        public GameConsole GetById(Guid id)
        {
            List<GameConsole> list = new List<GameConsole>();
            list.Add(new GameConsole() { Id = Guid.Parse("01bbd4d6-85a1-4a5b-8f11-29d5fb321143"), Name = "XBox", Description = "Kalle kula....", IPAddress = "192.168.0.1", ImageUrl = new Uri("http://www.impulsegamer.com/articles/wp-content/uploads/2017/11/xboxonexconsole.jpg") });
            list.Add(new GameConsole() { Id = Guid.Parse("d9bdbb8b-64b8-40bb-b3f9-8830acba6313"), Name = "Playstation", Description = "Kalle kula....", IPAddress = "192.168.0.2", ImageUrl = new Uri("https://images-na.ssl-images-amazon.com/images/I/71esByYMVHL._SL1500_.jpg") });
            list.Add(new GameConsole() { Id = Guid.Parse("dc8ed7d5-344d-4d51-8b8a-4b8a10d94c3f"), Name = "Gameboy", Description = "Kalle kula....", IPAddress = "192.168.0.3", ImageUrl = new Uri("http://www.impulsegamer.com/articles/wp-content/uploads/2017/11/xboxonexconsole.jpg") });

            return list.FirstOrDefault(gc => gc.Id == id);
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
