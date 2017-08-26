using Factory;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            VehicleFactory factory = new Vehicle();
            IVehicle car = factory.GetVehicle("Car");
            car.Drive();

            IVehicle bike = factory.GetVehicle("Bike");
            bike.Drive();

            Console.ReadLine();
        }
    }
}
