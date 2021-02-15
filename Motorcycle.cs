using System;
using System.Collections.Generic;
using System.Text;

namespace _5Garage
{
    class Motorcycle : Vehicle
    {
        public int TopSpeed { get; set; }
        public Motorcycle(string registrationNumber, string color, int numberOfSeats, int numberOfWheels, int topSpeed)
                    : base(registrationNumber, color, numberOfSeats, numberOfWheels)
        {
            TopSpeed = topSpeed;
        }
        public override string GetVehicleInfo()
        {
            return $" Vehicle type: Motorcycle { base.GetVehicleInfo()} Top speed:  {TopSpeed} ";
        }
    }
}
