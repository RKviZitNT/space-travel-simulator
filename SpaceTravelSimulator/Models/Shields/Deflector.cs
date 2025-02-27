namespace SpaceTravelSimulator.Models.Shields
{   
    public class Deflector : Shield
    {
        public Deflector(DeflectorType type, bool photonDeflector) : base(GetAsteroidProtection(type), GetMeteorProtection(type), GetSpaceWhaleProtection(type), photonDeflector) {}

        private static int GetAsteroidProtection(DeflectorType type)
        {
            return type switch
            {
                DeflectorType.NoShield => 0,
                DeflectorType.Class1 => 2,
                DeflectorType.Class2 => 10,
                DeflectorType.Class3 => 40,
                _ => 0
            };
        }

        private static int GetMeteorProtection(DeflectorType type)
        {
            return type switch
            {
                DeflectorType.NoShield => 0,
                DeflectorType.Class1 => 1,
                DeflectorType.Class2 => 3,
                DeflectorType.Class3 => 10,
                _ => 0
            };
        }

        private static int GetSpaceWhaleProtection(DeflectorType type)
        {
            return type switch
            {
                DeflectorType.NoShield => 0,
                DeflectorType.Class1 => 0,
                DeflectorType.Class2 => 0,
                DeflectorType.Class3 => 1,
                _ => 0
            };
        }
    }
}