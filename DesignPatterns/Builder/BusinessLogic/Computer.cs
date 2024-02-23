namespace Builder.BusinessLogic
{
	public class Computer
	{
        public string Processor { get; set; }
        public string RAM { get; set; }
        public string HardDisk { get; set; }
        public string GraphicCard { get; set; }

		public override string ToString()
		{
			return $"Computadora: Procesador={Processor}, RAM={RAM}, DiscoDuro={HardDisk}, TarjetaGrafica={GraphicCard}";
		}
	}
}
