using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class VehicleFactory
    {
        public void GetVehicle(int NumberOfTires)
        {
            switch (NumberOfTires)
            {
                case 2:
                    Motorcycle1 MyMoto = new Motorcycle1();
                    break;
                case 4:
                    Car MyCar = new Car();
                    break;
                default:
                    Console.WriteLine("Your vehicle cannot be made, sorry!");
                    break;
            }
        }

    }
}
