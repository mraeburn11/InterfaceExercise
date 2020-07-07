using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE - TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE - Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //DONE - In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            //DONE - *Create 2 members that are specific to each every company
            //regardless of vehicle type.


            //Example: public string Logo { get; set; }

            var myCar = new Car();
            var myTruck = new Truck();
            var newList = new List<IVehicle>();
            newList.Add(myCar);
            newList.Add(myTruck);
            
            foreach(var item in newList)
            {
                Console.WriteLine($"{item.GetType().Name} {item.EngineSize} {item.HasChangedGears} {item.Make} {item.Model}");
            }
            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
