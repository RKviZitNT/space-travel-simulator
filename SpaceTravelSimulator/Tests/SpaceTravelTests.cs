using NUnit.Framework;
using SpaceTravelSimulator.Models;
using SpaceTravelSimulator.Models.Ships;

namespace SpaceTravelSimulator.Tests
{
    public class SpaceTravelTests
    {
        [Test]
        public void TestRouteTraversal()
        {
            List<Ship> ships = new List<Ship> { new Astra(), new Orion(), new Helios(), new Centaur(), new Titan() };

            Route route1 = new Route();
            route1.AddSegment(EnvironmentType.NormalSpace, 1000, 2, 1, 0, false); // Обычный космос
            Route route2 = new Route();
            route2.AddSegment(EnvironmentType.HighDensityNebulae, 500, 0, 0, 0, true); // Туманность высокой плотности
            Route route3 = new Route();
            route3.AddSegment(EnvironmentType.NitrineParticleNebulae, 200, 5, 3, 1, false); // Нитринная туманность

            foreach (var ship in ships)
            {
                Console.WriteLine($"Тест на проходимость маршрута кораблём {ship.Name}:");
                route1.Traverse(ship);
                route2.Traverse(ship);
                route3.Traverse(ship);
                Console.WriteLine("\n");
            }
            
        }
    }
}