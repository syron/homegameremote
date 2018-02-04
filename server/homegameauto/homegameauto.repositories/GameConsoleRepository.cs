using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using homegameauto.models;
using Newtonsoft.Json;

namespace homegameauto.repositories
{
    public class GameConsoleRepository : IGameConsoleRepository
    {
        private string _folder { get; set; }

        public GameConsoleRepository(string folder)
        {
            _folder = folder;
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IList<GameConsole> GetAll()
        {
            using (StreamReader r = new StreamReader(string.Format(@"{0}/gameconsoles.json", _folder)))
            {
                string json = r.ReadToEnd();
                List<GameConsole> items = JsonConvert.DeserializeObject<List<GameConsole>>(json);
                return items;
            }
        }

        public GameConsole GetById(Guid id)
        {
            return GetAll().FirstOrDefault(gc => gc.Id == id);
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
