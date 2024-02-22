namespace AbstractFactory.Interfaces
{
	public interface IFurnitureFactory
	{
		public IChair CreateChair();
		public ISofa CreateSofa();
	}
}
