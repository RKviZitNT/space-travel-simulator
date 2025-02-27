using SpaceTravelSimulator.Models.Ships;

namespace SpaceTravelSimulator.Models
{
    public class Route
    {
        public List<Segment> Segments { get; set; } = new List<Segment>();

        public void AddSegment(EnvironmentType environment, double distance, int asteroids, int meteors, int spaceWhales, bool antimatterFlash)
        {
            Segments.Add(new Segment(environment, distance, asteroids, meteors, spaceWhales, antimatterFlash));
        }

        public void Traverse(Ship ship)
        {
            int segmentIndex = 0;
            foreach (var segment in Segments)
            {   
                if (!ship.Engine.CanPassEnvironment(segment.Environment))
                {
                    Console.WriteLine($"NO PASS. {ship.Name} утерян на сегменте {segment.Environment}. Причина: двигатель не подходит для космической среды");
                    return;
                }

                if (!ship.Shield.CanWithstand(segment.Asteroids, segment.Meteors, segment.SpaceWhales, segment.AntimatterFlash))
                {
                    Console.WriteLine($"NO PASS. {ship.Name} уничтожен на сегменте {segment.Environment}. Причина: защита корабля не выдержала столкновение с объектом");
                    return;
                }

                double fuelNeeded = ship.Engine.CalculateFuelConsumption(segment.Distance);
                Console.WriteLine($"PASS. {ship.Name} успешно прошёл сегмент {segment.Environment}, расстояние: {segment.Distance}, затрачено времени: {ship.Engine.CalculateTravelTime(segment.Distance)}, затрачено топлива: {fuelNeeded}");
                segmentIndex++;
            }
        }
    }
}