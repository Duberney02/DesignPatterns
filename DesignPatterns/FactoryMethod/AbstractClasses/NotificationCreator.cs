using FactoryMethod.Interfaces;

namespace FactoryMethod.AbstractClasses
{
	public abstract class NotificationCreator
	{
		public abstract INotification CreateNotification();
	}
}
