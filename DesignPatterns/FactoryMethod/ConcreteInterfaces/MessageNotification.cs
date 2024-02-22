using FactoryMethod.Interfaces;

namespace FactoryMethod.ConcreteInterfaces
{
	public class MessageNotification : INotification
	{
		public void Send(string message)
		{
			Console.WriteLine($"Enviando mensaje por app de mensajería: {message}");
		}
	}
}
