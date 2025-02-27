using SpaceTravelSimulator.Models.Engines;
using SpaceTravelSimulator.Models.Shields;

namespace SpaceTravelSimulator.Models.Ships
{
    public class Ship
    {
        public string Name { get; set; }
        public Engine Engine { get; set; }
        public Shield Shield { get; set; }

        protected Ship(string name, Engine engine, Shield shield)
        {
            Name = name;
            Engine = engine;
            Shield = shield;
        }
    }
}