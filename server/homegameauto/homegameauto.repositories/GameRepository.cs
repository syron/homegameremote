using System;
using System.Linq;
using System.Collections.Generic;
using homegameauto.models;

namespace homegameauto.repositories
{
    public class GameRepository : IGameRepository
    {
        public GameRepository()
        {
        }

        public IEnumerable<Game> GetAll()
        {
            List<Game> list = DemoList();
            return list;
        }

        public IEnumerable<Game> GetByConsoleId(Guid consoleId)
        {
            return GetAll().Where(g => g.ConsoleId == consoleId);
        }

        public Game GetById(Guid id)
        {
            return GetAll().FirstOrDefault(g => g.Id == id);
        }

        private List<Game> DemoList() {
            List<Game> list = new List<Game>();
            list.Add(new Game() { Id = Guid.Parse("707bf088-5aa4-4626-964e-5ea918ce3a54"), Name = "Sonic", Description = "Kalle Kula", ConsoleId = Guid.Parse("01bbd4d6-85a1-4a5b-8f11-29d5fb321143"), ImageUrl = new Uri("https://www.technobuffalo.com/wp-content/uploads/2016/06/sonic-the-hedgehog-5-470x310@2x.jpg") });
            list.Add(new Game() { Id = Guid.Parse("61e34ec1-5157-4597-9637-d7cbdcdfe547"), Name = "Super Mario", Description = "Kalle Kula", ConsoleId = Guid.Parse("01bbd4d6-85a1-4a5b-8f11-29d5fb321143"), ImageUrl = new Uri("https://cdn02.nintendo-europe.com/media/images/10_share_images/games_15/virtual_console_nintendo_3ds_7/SI_3DSVC_SuperMarioBros_image1600w.jpg") });
            list.Add(new Game() { Id = Guid.Parse("1afcae27-8240-4219-82f3-e41385417f7a"), Name = "Pokemon", Description = "Kalle Kula", ConsoleId = Guid.Parse("dc8ed7d5-344d-4d51-8b8a-4b8a10d94c3f"), ImageUrl = new Uri("https://romsmania.com/statics/assets/covers/gameboy-color/pokemon_yellow_cover_art_by_comunello76-d4xfrr5.jpg") });
            return list;
        }
    }
}
