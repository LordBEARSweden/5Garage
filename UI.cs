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
                          + "/n1. Seed dummy data"
                          + "/n2. List all paked vehicles & types of vehicles"
                          + "/n3. Add and Remove vehicles in the garage"
                          + "/n4. Search for spesicic vehicle with Registration number or search by filter"
                          + "/n0. Exit program"
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
