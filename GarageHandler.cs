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
            var vehicles = new List<Vehicle>
            {
                new Car("abc123", "black", 4, 4, "gasoline")

            };

            foreach (var vehicle in vehicles)
            {
                garage.Park(vehicle);
            }
        }

        internal List<Vehicle> GetVehicles()
        {

            var list = new List<Vehicle>();

            foreach (var v in garage)
            {
                list.Add(v);
            }
            
            return list;
        }

      
    }
}
