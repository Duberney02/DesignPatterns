using Adapter.BusinessLogic;
using Adapter.Interfaces;

namespace Adapter.ConcreteInterfaces
{
	public class AdapterPattern : ITarget
	{
		private readonly Adaptee _adaptee;

		public AdapterPattern(Adaptee adaptee)
		{
			this._adaptee = adaptee;
		}

		public string GetRequest()
		{
			return $"This is '{this._adaptee.GetSpecificRequest()}'";
		}
	}
}
