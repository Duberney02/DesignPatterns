using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcreteInterfaces
{
	public class FurnitureVictorianFactory : IFurnitureFactory
	{
		public IChair CreateChair()
		{
			return new VictorianChair();
		}

		public ISofa CreateSofa()
		{
			return new VictorianSofa();
		}
	}
}
