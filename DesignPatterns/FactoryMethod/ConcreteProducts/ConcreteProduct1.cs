﻿using FactoryMethod.Interfaces;

namespace FactoryMethod.ConcreteProducts
{
	public class ConcreteProduct1 : IProduct
	{
		public string Operation()
		{
			return "{Result of ConcreteProduct1}";
		}
	}
}