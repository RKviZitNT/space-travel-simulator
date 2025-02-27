namespace SpaceTravelSimulator.Models.Engines
{
    public class JumpEngineGamma : Engine
    {
        public JumpEngineGamma() : base(EngineType.JumpOmega, 2.5, 500.0) { }

        public override double CalculateFuelConsumption(double distance)
        {
            return distance * FuelConsumptionRate * Math.Pow(distance, 2);
        }
    }
}