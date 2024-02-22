using FactoryMethod.Interfaces;

namespace FactoryMethod.ConcreteProducts
{
	public class ConcreteProduct2 : IProduct
	{
		public string Operation()
		{
			return "{Result of ConcreteProduct2}";
		}
	}
}
