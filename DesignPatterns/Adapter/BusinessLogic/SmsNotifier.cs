namespace Adapter.BusinessLogic
{
	public class SmsNotifier
	{
		public void SendSms(string message)
		{
			Console.WriteLine($"Enviando SMS: {message}");
		}
	}
}
