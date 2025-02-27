using SpaceTravelSimulator.Models.Engines;
using SpaceTravelSimulator.Models.Shields;

namespace SpaceTravelSimulator.Models.Ships
{
    public class Helios : Ship
    {
        public Helios() : base("Helios", new ImpulseEngineE(), new Deflector(DeflectorType.Class2, false)) { }
    }
}