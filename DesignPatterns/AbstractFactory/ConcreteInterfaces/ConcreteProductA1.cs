using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcreteInterfaces
{
	public class ConcreteProductA1 : IAbstractProductA
	{
		public string UsefulFunctionA()
		{
			return "The result of the product A1.";
		}
	}
}
