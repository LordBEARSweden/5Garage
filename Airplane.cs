using System;
using System.Collections.Generic;
using System.Text;

namespace _5Garage
{
    class Airplane : Vehicle
    {
        public int WingSpan { get; set; }
        public Airplane(string registrationNumber, string color, int numberOfSeats, int numberOfWheels, int wingSpan)
                    : base(registrationNumber, color, numberOfSeats, numberOfWheels)
        {
            WingSpan = wingSpan;
        }
        public override string GetVehicleInfo()
        {
            return $" Vehicle type: Airplane { base.GetVehicleInfo()} Wingspan: {WingSpan} ";
        }
    }
}
