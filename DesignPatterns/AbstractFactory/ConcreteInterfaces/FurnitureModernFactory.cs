using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcreteInterfaces
{
	public class FurnitureModernFactory : IFurnitureFactory
	{
		public IChair CreateChair()
		{
			return new ModernChair();
		}

		public ISofa CreateSofa()
		{
			return new ModernSofa();
		}
	}
}
