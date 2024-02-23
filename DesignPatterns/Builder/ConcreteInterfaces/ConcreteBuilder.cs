﻿using Builder.BusinessLogic;
using Builder.Interfaces;

namespace Builder.ConcreteInterfaces
{
	public class ConcreteBuilder : IBuilder
	{
		private Product _product = new Product();

		public ConcreteBuilder()
		{
			this.Reset();
		}

		public void Reset()
		{
			_product = new Product();
		}

		public void BuildPartA()
		{
			_product.Add("PartA1");
		}

		public void BuildPartB()
		{
			_product.Add("PartB1");
		}

		public void BuildPartC()
		{
			_product.Add("PartC1");
		}

		public Product GetProduct()
		{
			Product result = _product;
			this.Reset();
			return result;
		}
	}
}
