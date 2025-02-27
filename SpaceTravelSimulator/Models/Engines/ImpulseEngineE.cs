namespace SpaceTravelSimulator.Models.Engines
{
    public class ImpulseEngineE : Engine
    {
        public ImpulseEngineE() : base(EngineType.ImpulseE, 2.0, 200.0) { }

        public override double CalculateFuelConsumption(double distance)
        {
            return distance * FuelConsumptionRate * Math.Exp(distance / 1000.0);
        }
    }
}