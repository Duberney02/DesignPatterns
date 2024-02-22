using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcreteInterfaces
{
	public class ConcreteFactory2 : IAbstractFactory
	{
		public IAbstractProductA CreateProductA()
		{
			return new ConcreteProductA2();
		}

		public IAbstractProductB CreateProductB()
		{
			return new ConcreteProductB2();
		}
	}
}
