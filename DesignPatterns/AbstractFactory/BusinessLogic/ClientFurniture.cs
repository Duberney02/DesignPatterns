using AbstractFactory.ConcreteInterfaces;
using AbstractFactory.Interfaces;

namespace AbstractFactory.BusinessLogic
{
	public class ClientFurniture
	{
		public void Execute()
		{
			IFurnitureFactory furniture = new FurnitureModernFactory();
			IChair modernChair = furniture.CreateChair();
			ISofa modernSofa = furniture.CreateSofa();

			Console.WriteLine($"Creando una silla de estilo {modernChair.Style}.");
			modernChair.Sit();

			Console.WriteLine($"Creando un sofá de estilo {modernSofa.Style}.");
			modernSofa.Lean();

			furniture = new FurnitureVictorianFactory();
			IChair victorianChair = furniture.CreateChair();
			ISofa victorianSofa = furniture.CreateSofa();

			Console.WriteLine($"Creando una silla de estilo {victorianChair.Style}.");
			victorianChair.Sit();

			Console.WriteLine($"Creando un sofá de estilo {victorianSofa.Style}.");
			victorianSofa.Lean();
		}

	}
}
