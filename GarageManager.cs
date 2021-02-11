using System;

namespace _5Garage
{
    internal class GarageManager
    {
        private GarageHandler handler;
        private UI ui;

        public GarageManager()
        {
            ui = new UI();
        }

        public void Start()
        {
            CreateGarage();
            MainProgram();
        }

        private void MainProgram()
        {
           

            ui.ShowMainMeny();
            var input = ui.GetInput();
            Run(input);
               
            //Application exit
          
        }

        private void Run(string input)
        {
            switch (input)
            {
                case "1":
                    Seeddata();

                    break;

                case "2":
                    ListVehicles();
                    break;
                case "3":

                    break;

                case "4":
                    break;

                case "0":
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    
                    break;
            }
        }

        private void ListVehicles()
        {
            handler.GetVehicles();
        }

        private void Seeddata()
        {
            handler.Seed();
        }

        private void CreateGarage()
        {
            Console.WriteLine("Program Starts");
            //Ask for size
            //Loop until
            bool ok = false;
            do
            {
                 Console.WriteLine("Size?");
                if (int.TryParse(Console.ReadLine(), out int size))
                {
                    //Check correct value
                    handler = new GarageHandler(size);
                    ok = true;
                }

            } while (!ok);
        }
    }
}