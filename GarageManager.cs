using System;

namespace _5Garage
{
    internal class GarageManager
    {
        private  GarageHandler handler;
        private  UI ui;

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

        }

        private void Run(string input)
        {
            switch (input)
            {
                case "1":

                default:
                    break;
            }
        }

        private  void CreateGarage()
        {
            //Welcome 
            //Ask for size
            //Loop until
           if( int.TryParse(Console.ReadLine(), out int size))
            {
                //Check correct value
                handler = new GarageHandler(size);
            }
            else
            {
                
            }
        }
    }
}