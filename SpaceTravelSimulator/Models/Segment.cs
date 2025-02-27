namespace SpaceTravelSimulator.Models
{
    public class Segment
    {
        public EnvironmentType Environment { get; set; }
        public double Distance { get; set; }
        public int Asteroids { get; set; }
        public int Meteors { get; set; }
        public int SpaceWhales { get; set; }
        public bool AntimatterFlash { get; set; }

        public Segment(EnvironmentType environment, double distance, int asteroids, int meteors, int spaceWhales, bool antimatterFlash)
        {
            Environment = environment;
            Distance = distance;
            Asteroids = asteroids;
            Meteors = meteors;
            SpaceWhales = spaceWhales;
            AntimatterFlash = antimatterFlash;
        }
    }
}