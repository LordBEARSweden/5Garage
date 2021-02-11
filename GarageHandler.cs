using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5Garage
{
    class GarageHandler : UI
    {
        Garage<Vehicle> garage;

       public GarageHandler(int size)
        {
            garage = new Garage<Vehicle>(size);
        }

        internal void Seed()
        {
           // var rödafordon = garage.Where(v => v.Color == "Röd");
            var vehicles = GetVehicles();

            foreach (var vehicle in vehicles)
            {
                garage.Park(vehicle);
            }
        }

        private List<Vehicle> GetVehicles()
        {
            return new List<Vehicle>
            {
                //new Car(),
                //new Car(),
                //new Car(),
                //new Car(),
            };
        }
    }
}
