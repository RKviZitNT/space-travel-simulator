using SpaceTravelSimulator.Models.Engines;
using SpaceTravelSimulator.Models.Shields;

namespace SpaceTravelSimulator.Models.Ships
{
    public class Orion : Ship
    {
        public Orion() : base("Orion", new JumpEngineGamma(), new Deflector(DeflectorType.Class1, false)) { }
    }
}