using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : ICompany, IVehicle
    {
        public string CompanyName { get; set; } = "Dodge";
        public string Moto { get; set; } = "Like a rock";
        public double EngineSize { get; set; } = 5.0;
        public string Make { get; set; } = "Dodge";
        public string Model { get; set; } = "Ram";
        public int SeatCount { get; set; } = 4;
        public bool HasChangedGears { get; set; }

        

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now moving forward...");
        }

        public void Park()
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

        public void Reverse()
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
