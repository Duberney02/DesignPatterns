using FactoryMethod.AbstractClasses;
using FactoryMethod.ConcreteInterfaces;
using FactoryMethod.Interfaces;

namespace FactoryMethod.ConcreteCreators
{
	public class ConcreteCreator2 : Creator
	{
		public override IProduct FactoryMethod()
		{
			return new ConcreteProduct2();
		}
	}
}
