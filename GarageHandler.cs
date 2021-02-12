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
                new Car("abc123", "Black", 5, 4, "gasoline"),
                new Motorcycle("PDF465", "Red", 1, 2, 300),
                new Airplane("AIR206", "White", 200, 24, 40),
                new Bus("BUS049", "Yellow", 40, 6, 12),
                new Boat("BÅT001", "Blue", 6, 0, 2)
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
