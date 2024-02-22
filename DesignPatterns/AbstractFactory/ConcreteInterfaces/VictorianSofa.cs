using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcreteInterfaces
{
	public class VictorianSofa : ISofa
	{
		public string Style => "Victoriano";

		public void Lean()
		{
			Console.WriteLine("Recostado en un sofá victoriano.");
		}
	}
}
