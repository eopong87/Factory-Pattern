using System;
namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {



        public void Build()
        {
            Console.WriteLine("This is Bike drives fast!!!");
            Console.WriteLine("Lets ride Out");
        }
    }

}

