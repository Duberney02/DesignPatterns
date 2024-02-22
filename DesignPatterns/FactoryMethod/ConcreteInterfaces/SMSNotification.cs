using FactoryMethod.Interfaces;

namespace FactoryMethod.ConcreteInterfaces
{
	public class SMSNotification : INotification
	{
		public void Send(string message)
		{
			Console.WriteLine($"Enviando notificación por SMS: {message}");
		}
	}
}
