namespace SpaceTravelSimulator.Models.Shields
{
    public class Shield
    {
        public int AsteroidProtection { get; set; }
        public int MeteorProtection { get; set; }
        public int SpaceWhaleProtection { get; set; }
        public bool PhotonDeflector { get; set; }

        protected Shield(int asteroidProtection, int meteorProtection, int spaceWhaleProtection, bool photonDeflector)
        {
            AsteroidProtection = asteroidProtection;
            MeteorProtection = meteorProtection;
            SpaceWhaleProtection = spaceWhaleProtection;
            PhotonDeflector = photonDeflector;
        }

        public bool CanWithstand(int asteroids, int meteors, int spaceWhales, bool antimatterFlash)
        {   
            if (antimatterFlash)
            {
                if (!PhotonDeflector)
                {
                    return false;
                }
            }
            if (AsteroidProtection >= asteroids &&
                MeteorProtection >= meteors &&
                SpaceWhaleProtection >= spaceWhales)
            {
                AsteroidProtection -= asteroids;
                MeteorProtection -= meteors;
                SpaceWhaleProtection -= spaceWhales;

                return true;
            }
            return false;
        }
    }
}