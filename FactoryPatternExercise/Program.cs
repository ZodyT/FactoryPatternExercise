using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires does your vehicle have?");
            int NumberOfTires = Convert.ToInt32(Console.ReadLine());

            var myVehicle = VehicleFactory.GetVehicle(NumberOfTires);
            myVehicle.Drive();
        }
    }
}
