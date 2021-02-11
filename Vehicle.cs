using System;
using System.Collections.Generic;
using System.Text;

namespace _5Garage
{
   abstract class Vehicle
    {
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfSeats { get; set; }

        public Vehicle(string registrationNumber, string color, int numberOfWheels, int numberOfSeats)
        {
            RegistrationNumber = registrationNumber;
            Color = color;
            NumberOfWheels = numberOfWheels;
            NumberOfSeats = numberOfSeats;

        }
    }
}
