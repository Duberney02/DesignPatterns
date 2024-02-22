using FactoryMethod.AbstractClasses;
using FactoryMethod.ConcreteInterfaces;
using FactoryMethod.Interfaces;

namespace FactoryMethod.ConcreteCreators
{
	internal class EmailNotificationCreator : NotificationCreator
	{
		public override INotification CreateNotification()
		{
			return new EmailNotification();
		}
	}
}
