using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRaceGame.Models
{
    internal class Truck : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Truck is moving..");
        }
    }
}
