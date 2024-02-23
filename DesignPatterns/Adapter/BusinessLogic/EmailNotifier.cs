using Adapter.Interfaces;

namespace Adapter.BusinessLogic
{
	public class EmailNotifier : IEmailNotifier
	{
		public void SendEmail(string message)
		{
			Console.WriteLine($"Enviando correo electrónico: {message}");
		}
	}
}
