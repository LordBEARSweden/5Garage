using System;
using System.Collections.Generic;
using System.Text;

namespace _5Garage
{
    class Boat : Vehicle
    {
        public int NumberOfEngines { get; set; }
        public Boat(string registrationNumber, string color, int numberOfSeats, int numberOfWheels, int numberOfEngines)
                    : base(registrationNumber, color, numberOfSeats, numberOfWheels)
        {
            NumberOfEngines = numberOfEngines;
        }
    }
}
