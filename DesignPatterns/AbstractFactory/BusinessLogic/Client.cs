using AbstractFactory.ConcreteInterfaces;
using AbstractFactory.Interfaces;

namespace AbstractFactory.BusinessLogic
{
	public class Client
	{
		public void Main()
		{
			// The client code can work with any concrete factory class.
			Console.WriteLine("Client: Testing client code with the first factory type...");
			ClientMethod(new ConcreteFactory1());
			Console.WriteLine();

			Console.WriteLine("Client: Testing the same client code with the second factory type...");
			ClientMethod(new ConcreteFactory2());
		}

		private void ClientMethod(IAbstractFactory factory)
		{
			var producA = factory.CreateProductA();
			var producB = factory.CreateProductB();
		}

		
	}
}
