using Builder.BusinessLogic;
using Builder.Interfaces;

namespace Builder.ConcreteInterfaces
{
	public class ComputerBuilder : IComputerBuilder
	{
		private Computer _computer;
        public ComputerBuilder()
        {
            _computer = new Computer();
        }
        public IComputerBuilder AddCraphicCard(string graphicCard)
		{
			_computer.GraphicCard = graphicCard;
			return this;
		}

		public IComputerBuilder AddHardDisck(string hardDisck)
		{
			_computer.HardDisk = hardDisck;
			return this;
		}

		public IComputerBuilder AddProcessor(string processor)
		{
			_computer.Processor = processor;
			return this;
		}

		public IComputerBuilder AddRAM(string ram)
		{
			_computer.RAM = ram;
			return this;
		}

		public Computer Build()
		{
			Computer result = _computer;
			_computer = new Computer();
			return result;
		}
	}
}
