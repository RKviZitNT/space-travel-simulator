namespace SpaceTravelSimulator.Models.Engines
{
    public abstract class Engine
    {
        public EngineType Type { get; set; }
        public double FuelConsumptionRate { get; set; }
        public double Speed { get; set; }

        protected Engine(EngineType type, double fuelConsumptionRate, double speed)
        {
            Type = type;
            FuelConsumptionRate = fuelConsumptionRate;
            Speed = speed;
        }

        public abstract double CalculateFuelConsumption(double distance);

        public double CalculateTravelTime(double distance)
        {
            return distance / Speed;
        }

        public bool CanPassEnvironment(EnvironmentType type)
        {
            switch (type)
            {
                case EnvironmentType.NormalSpace:
                    return Type == EngineType.ImpulseC || Type == EngineType.ImpulseE;

                case EnvironmentType.HighDensityNebulae:
                    return Type == EngineType.JumpAlpha || Type == EngineType.JumpOmega || Type == EngineType.JumpGamma;

                case EnvironmentType.NitrineParticleNebulae:
                    return Type == EngineType.ImpulseE;

                default:
                    return false;
            }
        }
    }
}