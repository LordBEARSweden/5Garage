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
            do
            {
               // Console.Clear();
               // Console.ReadLine();
                ui.ShowMainMeny();
                var input = ui.GetInput();
                Run(input);

            } while (true);

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
                    AddRemoveVehicles();
                    break;

                case "4":
                    SearchVehicle();
                    break;

                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input");

                    break;
            }
        }


        private void SearchVehicle()
        {
            Console.WriteLine("Search");
        }

        private void AddRemoveVehicles()
        {
            Console.WriteLine("Add/Remove");
            //Meny for add or remove
            //If add vilket fordon osv...
            //If remove vilket fordon...
        }

        private void ListVehicles()
        {
            foreach (var vehicle in handler.GetVehicles())
            {
                //$"Regnummer: {regnrummer}"
                ui.Print(vehicle.GetVehicleInfo());
               // ui.Print(vehicle);
                //Anropa ui
                //Skriv ut ALLA properties för det specifika fordonet
               //Console.WriteLine();
            }

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
                Console.WriteLine("How big do you want the Garage?");
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