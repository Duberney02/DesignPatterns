using FactoryMethod.AbstractClasses;
using FactoryMethod.ConcreteInterfaces;
using FactoryMethod.Interfaces;

namespace FactoryMethod.ConcreteCreators
{
	public class SMSNotificationCreator : NotificationCreator
	{
		public override INotification CreateNotification()
		{
			return new SMSNotification();
		}
	}
}
