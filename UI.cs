using System;
using System.Collections.Generic;
using System.Text;

namespace _5Garage
{
    class UI
    {
        public void ShowMainMeny()
        {
            
            Console.WriteLine("Welcome to the Garage!  Main Menu ");
            Console.WriteLine("Please select an option by entering a number");
            Console.WriteLine("1. Seed dummy data");
            Console.WriteLine("2. List all paked vehicles & types of vehicles");
            Console.WriteLine("3. Add and Remove vehicles in the garage");
            Console.WriteLine("4. Search for spesicic vehicle with Registration number or search by filter");
            Console.WriteLine("0. Exit program");
        }

      
        //Take char string key ....
        internal string GetInput()
        {
            
            //Get input
            return Console.ReadLine();  //Tas bort
        }

        internal void Print<T>(T message)
        {
            Console.WriteLine(message);
        }
       
        public void AddRemoveVehicles()
        {
            
        }
    }
}
