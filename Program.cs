using VehicleRaceGame.Models;

namespace VehicleRaceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMovable[] movables = new IMovable[]
            {
                new Car(),
                new Bike(),
                new Truck()
            }; 
            StartRace(movables);
        }
        static void StartRace(IMovable[] movables) 
        {
            foreach (IMovable movable in movables)
                movable.Move();
        }
    }
}
