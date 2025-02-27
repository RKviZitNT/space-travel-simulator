namespace SpaceTravelSimulator.Models.Engines
{
    public class JumpEngineAlpha : Engine
    {
        public JumpEngineAlpha() : base(EngineType.JumpAlpha, 1.5, 300.0) { }

        public override double CalculateFuelConsumption(double distance)
        {
            return distance * FuelConsumptionRate;
        }
    }
}