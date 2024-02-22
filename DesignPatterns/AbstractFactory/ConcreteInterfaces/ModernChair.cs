using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcreteInterfaces
{
	public class ModernChair : IChair
	{
		public string Style => "Moderna";

		public void Sit()
		{
			Console.WriteLine("Sentado en una silla moderna.");
		}
	}
}
