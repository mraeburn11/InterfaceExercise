using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car(double size)
        {
            EngineSize = size;
        }
        public Car()
        {

        }


        public double EngineSize { get; set; } = 4.6;
        public string Make { get; set; } = "Whatever";
        public string Model { get; set; } = "Fast";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Dodge";
        public string Moto { get; set; } = "Nothing like a Charger";
        public bool HasChangedGears { get; private set; }
        bool IVehicle.HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now moving forward...");
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }

        }



        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now in park...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears");
            }
        }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }


    }

}
