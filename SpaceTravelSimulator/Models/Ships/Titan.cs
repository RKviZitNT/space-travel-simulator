using SpaceTravelSimulator.Models.Engines;
using SpaceTravelSimulator.Models.Shields;

namespace SpaceTravelSimulator.Models.Ships
{
    public class Titan : Ship
    {
        public Titan() : base("Titan", new JumpEngineGamma(), new Deflector(DeflectorType.Class3, true)) { }
    }
}