using System;
namespace homegameauto.models
{
    public class Game
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid ConsoleId { get; set; }
        public Uri ImageUrl { get; set; }
        public string Executable { get; set; }
    }
}
