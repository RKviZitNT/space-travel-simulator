namespace SpaceTravelSimulator.Models.Engines
{
    public class ImpulseEngineC : Engine
    {
        public ImpulseEngineC() : base(EngineType.ImpulseC, 1.0, 100.0) { }

        public override double CalculateFuelConsumption(double distance)
        {
            return distance * FuelConsumptionRate;
        }
    }
}