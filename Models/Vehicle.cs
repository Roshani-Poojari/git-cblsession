﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRaceGame.Models
{
    internal abstract class Vehicle : IMovable
    {
        public abstract void Move();
        
    }
}
