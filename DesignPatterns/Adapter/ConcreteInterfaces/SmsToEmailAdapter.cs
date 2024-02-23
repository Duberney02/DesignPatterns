using Adapter.BusinessLogic;
using Adapter.Interfaces;

namespace Adapter.ConcreteInterfaces
{
	internal class SmsToEmailAdapter : IEmailNotifier
	{
		private readonly SmsNotifier _smsNotifier;

		public SmsToEmailAdapter(SmsNotifier smsNotifier)
		{
			_smsNotifier = smsNotifier;
		}

		public void SendEmail(string message)
		{
			_smsNotifier.SendSms(message);
		}
	}
}
