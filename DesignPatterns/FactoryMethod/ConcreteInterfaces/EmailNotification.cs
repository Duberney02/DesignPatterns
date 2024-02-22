using FactoryMethod.Interfaces;

namespace FactoryMethod.ConcreteInterfaces
{
	public class EmailNotification : INotification
	{
		public void Send(string message)
		{
			Console.WriteLine($"Enviando notificación por email: {message}");
		}
	}
}
