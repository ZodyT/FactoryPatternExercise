using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
   public static class VehicleFactory
   {
        public static IVehicle GetVehicle(int NumberOfTires)
        {
            switch (NumberOfTires)
            {
                case 2:
                    return new Motorcycle1();                                                   
                case 4:
                    return new Car();
                default:
                    Console.WriteLine("Your vehicle cannot be made, sorry!");
                    break;
            }
        }
   }
}
