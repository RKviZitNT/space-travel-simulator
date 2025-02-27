using SpaceTravelSimulator.Models.Engines;
using SpaceTravelSimulator.Models.Shields;

namespace SpaceTravelSimulator.Models.Ships
{
    public class Centaur : Ship
    {
        public Centaur() : base("Centaur", new JumpEngineOmega(), new Deflector(DeflectorType.Class2, true)) { }
    }
}