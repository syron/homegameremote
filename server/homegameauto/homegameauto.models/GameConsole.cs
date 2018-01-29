using System;

namespace homegameauto.models
{
    public class GameConsole
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IPAddress { get; set; }
    }
}
