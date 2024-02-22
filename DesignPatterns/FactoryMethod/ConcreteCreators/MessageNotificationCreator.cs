using FactoryMethod.AbstractClasses;
using FactoryMethod.ConcreteInterfaces;
using FactoryMethod.Interfaces;

namespace FactoryMethod.ConcreteCreators
{
	public class MessageNotificationCreator : NotificationCreator
	{
		public override INotification CreateNotification()
		{
			return new MessageNotification();
		}
	}
}
