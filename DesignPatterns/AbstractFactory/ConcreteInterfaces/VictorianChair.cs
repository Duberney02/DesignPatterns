using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcreteInterfaces
{
	public class VictorianChair : IChair
	{
		public string Style => "Victoriana";

		public void Sit()
		{
			Console.WriteLine("Sentado en una silla victoriana.");
		}
	}
}
