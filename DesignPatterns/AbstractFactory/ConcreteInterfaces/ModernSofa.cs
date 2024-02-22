using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcreteInterfaces
{
	public class ModernSofa : ISofa
	{
		public string Style => "Moderno";

		public void Lean()
		{
			Console.WriteLine("Recostado en un sofá moderno.");
		}
	}
}
