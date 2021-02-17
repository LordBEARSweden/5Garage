using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5Garage
{
    class GarageHandler : UI
    {
        Garage<Vehicle> garage;
        //public Garage<Vehicle> Garage { get; set; }

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
           return garage.ToList();
            /*
            var list = new List<Vehicle>();

            foreach (var v in garage)
            {
                list.Add(v);
            }
            
            return list;*/ 
        }

        
        internal void Park(Vehicle vehicle)
        {
            garage.Park(vehicle);
        }

        public bool RegCheck(string regnr)
        {
            foreach (var vehicle in garage)
            {
                if (regnr == vehicle.RegistrationNumber)
                {
                    return false;
                }
            }
            return true;
        }

        internal Vehicle GetByRegNO(string regnr)
        {
            var v = garage.FirstOrDefault(v => v.RegistrationNumber == regnr);
            return v;
        }

        public List<Vehicle> GetByColor(string color)
        {
            var v = garage.Where(v => v.Color == color).ToList();
            return v;
        }

        public void Remove(string regnr)
        {
            garage.Remove(regnr);
        }



    }

    
          
}
