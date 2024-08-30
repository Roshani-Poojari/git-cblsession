using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRaceGame.Models
{
    internal class Bike : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Bike is moving..");
        }
    }
}
