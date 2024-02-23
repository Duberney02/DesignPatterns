using Builder.BusinessLogic;

namespace Builder.Interfaces
{
	public interface IComputerBuilder
	{
		IComputerBuilder AddProcessor(string processor);
		IComputerBuilder AddRAM(string ram);
		IComputerBuilder AddHardDisck(string hardDisck);
		IComputerBuilder AddCraphicCard(string graphicCard);
		Computer Build();
	}
}
