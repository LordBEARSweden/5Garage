using System;
using System.Collections.Generic;
using System.Text;

namespace _5Garage
{
    class Car : Vehicle
    {
        public string FuelType { get; set; }
        public Car(string registrationNumber, string color, int numberOfSeats, int numberOfWheels, string fueltype)
                    : base(registrationNumber, color, numberOfSeats, numberOfWheels)
        {
            FuelType = fueltype;
        }

        public override string GetVehicleInfo()
        {
            return $" Vehicle type: Car { base.GetVehicleInfo()}  {FuelType} ";
        }

    } 
}
