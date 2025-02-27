using SpaceTravelSimulator.Models.Engines;
using SpaceTravelSimulator.Models.Shields;

namespace SpaceTravelSimulator.Models.Ships
{
    public class Astra : Ship
    {
        public Astra() : base("Astra", new ImpulseEngineC(), new Deflector(DeflectorType.NoShield, false)) { }
    }
}