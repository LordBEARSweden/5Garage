using System;
using System.Collections.Generic;
using System.Text;

namespace _5Garage
{
    class UI
    {
        public void ShowMainMeny()
        {
            Console.WriteLine("Welcome to the Garage! /n Main Menu /n Please select an option by entering a number"
                          + "/n1. List all paked vehicles"
                          + "/n2. List vehicle types and number of that type"
                          + "/n3. Ad and Remove vehicles in the garage"
                          + "/n5. Seed dummy data"
                          + "/n5. Search for spesicic vehicle with Registration number"
                          + "/n6. Searching for vehicles"
                          + "/n7. Searching for vehicles"
                          + "/n8. Searching for vehicles"
                          + "/n0. Searching for vehicles"
                          );

        }

        //Take char string key ....
        internal string GetInput()
        {
            //Get input
            return ""; //Tas bort
        }
    }
}
