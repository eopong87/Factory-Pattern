using System;
namespace FactoryPattern
{
	public class ThreeWheeler:IVehicle
	{
		public ThreeWheeler()
		{
		}
		public void Build()
		{
           Console.WriteLine("The three wheeler is driving");
		}
			
	}
}

