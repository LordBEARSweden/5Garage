using System;
using System.Collections.Generic;
using System.Text;

namespace _5Garage
{
    class Bus : Vehicle
    {
        public int Lenght { get; set; }
        public Bus(string registrationNumber, string color, int numberOfSeats, int numberOfWheels, int lenght)
                    : base(registrationNumber, color, numberOfSeats, numberOfWheels)
        {
            Lenght = lenght;
        }
        public override string GetVehicleInfo()
        {
            return $" Vehicle type: Bus { base.GetVehicleInfo()} Lenght:  {Lenght} ";
        }
    }
}
