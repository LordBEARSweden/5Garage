using System;

namespace _5Garage
{
    internal class GarageManager
    {
        private GarageHandler handler;
        private UI ui;

        public int AddOrRemove { get; private set; }

        public GarageManager()
        {
            ui = new UI();
            //handler = new GarageHandler();
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
                ui.ShowMainMeny();
                var input = ui.GetInput();
                Run(input);
                Console.WriteLine("press Enter to continue");
                Console.ReadLine();

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
            Console.WriteLine("Add or Remove vehicle?");
            Console.WriteLine("Press 1 to add");
            Console.WriteLine("Press 2 to remove");

            string addOrRemove = Console.ReadLine();
            int AddOrRemove = Int32.Parse(addOrRemove);
            if (AddOrRemove == 1)
            {
                Console.WriteLine("What type of Vehicle do you want to add?");
                Console.WriteLine("Press 1 for Car, 2 for Bus, 3 for Motorcycle, 4 for Airplane, 5 for Boat");
                var input = ui.GetInput();
                Add(input);

                void Add(string input)
                {
                    switch (input)
                    {
                        case "1":
                            Console.WriteLine("Enter Registration number");
                           string registrationNumber = Console.ReadLine();
                            Console.WriteLine("What color is the car?");
                            string color = Console.ReadLine();
                            Console.WriteLine("How many seats does the car have?");
                            int seats = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("How many wheels does the car have?");
                            int wheels = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("What fuel does the Car use?");
                            string fuelType = Console.ReadLine();

                            var car = new Car(registrationNumber, color, seats, wheels, fuelType);
                            handler.Park(car);
                            break;

                        case "2":
                            Console.WriteLine("Enter Registration number");
                            string registrationNumber1 = Console.ReadLine();
                            Console.WriteLine("What color is the car?");
                            string color1 = Console.ReadLine();
                            Console.WriteLine("How many seats does the car have?");
                            int seats1 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("How many wheels does the car have?");
                            int wheels1 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("How long is the bus?");
                            int lenght = Int32.Parse(Console.ReadLine());

                            var bus = new Bus(registrationNumber1, color1, seats1, wheels1, lenght);
                            handler.Park(bus);
                            break;

                        case "3":
                            Console.WriteLine("Enter Registration number");
                            string registrationNumber2 = Console.ReadLine();
                            Console.WriteLine("What color is the car?");
                            string color2 = Console.ReadLine();
                            Console.WriteLine("How many seats does the car have?");
                            int seats2 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("How many wheels does the car have?");
                            int wheels2 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("How long is the bus?");
                            int topSpeed = Int32.Parse(Console.ReadLine());

                            var motorcycle = new Motorcycle(registrationNumber2, color2, seats2, wheels2, topSpeed);
                            handler.Park(motorcycle);
                            break;

                        case "4":
                            Console.WriteLine("Enter Registration number");
                            string registrationNumber3 = Console.ReadLine();
                            Console.WriteLine("What color is the car?");
                            string color3 = Console.ReadLine();
                            Console.WriteLine("How many seats does the car have?");
                            int seats3 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("How many wheels does the car have?");
                            int wheels3 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("How long is the bus?");
                            int wingSpan = Int32.Parse(Console.ReadLine());

                            var airplane = new Airplane(registrationNumber3, color3, seats3, wheels3, wingSpan);
                            handler.Park(airplane);
                            break;

                        case "5":
                            Console.WriteLine("Enter Registration number");
                            string registrationNumber4 = Console.ReadLine();
                            Console.WriteLine("What color is the car?");
                            string color4 = Console.ReadLine();
                            Console.WriteLine("How many seats does the car have?");
                            int seats4 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("How many wheels does the car have?");
                            int wheels4 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("How long is the bus?");
                            int numberOfEngines = Int32.Parse(Console.ReadLine());

                            var boat = new Boat(registrationNumber4, color4, seats4, wheels4, numberOfEngines);
                            handler.Park(boat);
                            break;

                        case "0":
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid input");

                            break;
                    }
                }

            }
            if (AddOrRemove == 2)
            {
                Console.WriteLine("Enter the vehicles Registration number");
                Console.ReadLine();
            }
            else MainProgram();
        }

        private void ListVehicles()
        {
            foreach (var vehicle in handler.GetVehicles())
            {
                ui.Print(vehicle.GetVehicleInfo());
            }

        }

        private void Seeddata()
        {
                Console.Clear();
                Console.WriteLine("Seed Successfully loaded");
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