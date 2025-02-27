namespace SpaceTravelSimulator.Models.Engines
{
    public class JumpEngineOmega : Engine
    {
        public JumpEngineOmega() : base(EngineType.JumpGamma, 2.0, 400.0) { }

        public override double CalculateFuelConsumption(double distance)
        {
            return distance * FuelConsumptionRate * Math.Log(distance + 1);
        }
    }
}