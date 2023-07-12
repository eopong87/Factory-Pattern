using System;
namespace FactoryPattern
{
    public class Car : IVehicle
    {

        public Car()
        {
        }
        public void Build()

        {
            Console.WriteLine("This carn can drive!");
        }
    }
}

