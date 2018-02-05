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
        private string _gameConsolesFile { 
            get 
            {
                return string.Format(@"{0}/gameconsoles.json", _folder);
            }
        }

        public GameConsoleRepository(string folder)
        {
            _folder = folder;
        }

        public void Delete(Guid id)
        {
            var gameConsoles = GetAll();
            var gameConsole = gameConsoles.FirstOrDefault(gc => gc.Id == id);
            if (gameConsole != null) 
                gameConsoles.Remove(gameConsole);
            
            SaveJson(gameConsoles);
        }

        public IList<GameConsole> GetAll()
        {
            using (StreamReader r = new StreamReader(_gameConsolesFile))
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
            var gameConsoles = GetAll();
            gameConsoles.Add(console);
            SaveJson(gameConsoles);
        }

        public void Update(GameConsole console)
        {
            var gameConsoles = GetAll();
            var gameConsole = gameConsoles.FirstOrDefault(gc => gc.Id == console.Id);

            var foundIndex = gameConsoles.IndexOf(gameConsole);
            gameConsoles[foundIndex] = console;

            SaveJson(gameConsoles);
        }

        private void SaveJson(IList<GameConsole> gameConsoles) {
            File.WriteAllText(_gameConsolesFile, JsonConvert.SerializeObject(gameConsoles));
        }
    }
}
