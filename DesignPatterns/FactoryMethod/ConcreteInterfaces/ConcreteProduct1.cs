using FactoryMethod.Interfaces;

namespace FactoryMethod.ConcreteInterfaces
{
	public class ConcreteProduct1 : IProduct
	{
		public string Operation()
		{
			return "{Result of ConcreteProduct1}";
		}
	}
}
