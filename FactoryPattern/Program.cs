namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            var instance = VehicleFactory.GetVehicle(2);  // IVehicle instance = new Car();
            instance.Build();

        }
    }
}
