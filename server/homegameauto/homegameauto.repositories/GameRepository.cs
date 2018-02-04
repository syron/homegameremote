using System;
using System.Linq;
using System.Collections.Generic;
using homegameauto.models;
using System.IO;
using Newtonsoft.Json;

namespace homegameauto.repositories
{
    public class GameRepository : IGameRepository
    {
        private string _folder { get; set; }

        public GameRepository(string folder)
        {
            _folder = folder;
        }

        public IEnumerable<Game> GetAll()
        {
            using (StreamReader r = new StreamReader(string.Format(@"{0}/games.json", _folder)))
            {
                string json = r.ReadToEnd();
                List<Game> items = JsonConvert.DeserializeObject<List<Game>>(json);
                return items;
            }
        }

        public IEnumerable<Game> GetByConsoleId(Guid consoleId)
        {
            return GetAll().Where(g => g.ConsoleId == consoleId);
        }

        public Game GetById(Guid id)
        {
            return GetAll().FirstOrDefault(g => g.Id == id);
        }
    }
}
