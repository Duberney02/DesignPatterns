﻿using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcreteInterfaces
{
	public class ConcreteProductB2 : IAbstractProductB
	{
		public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
		{
			var result = collaborator.UsefulFunctionA();

			return $"The result of the B1 collaborating with the ({result})";
		}

		public string UsefulFunctionB()
		{
			return "The result of the product B2.";
		}
	}
}
