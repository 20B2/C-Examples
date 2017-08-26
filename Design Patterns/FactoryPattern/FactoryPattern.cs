using System;

namespace Factory
{
    public interface IVehicle 
    {
        void Drive();
    }

    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving Car");
        }
    }

    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Drivinf Bike");
        }
    }


    public abstract class VehicleFactory
    {
        public abstract IVehicle GetVehicle(string Vehicle);
    }

    public class Vehicle:VehicleFactory
    {
        public override IVehicle GetVehicle(string vehicle)
        {
            switch(vehicle)
            {
                case "Car":
                    return new Car();
                case "Bike":
                    return new Bike();
                default:
                    throw new ApplicationException($"Vehicle { vehicle } canot be created");
            }
        }
    }
}