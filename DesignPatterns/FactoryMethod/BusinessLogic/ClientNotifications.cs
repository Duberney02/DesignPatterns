using FactoryMethod.AbstractClasses;
using FactoryMethod.ConcreteCreators;

namespace FactoryMethod.BusinessLogic
{
	public class ClientNotifications
	{
		public void Execute()
		{
			NotificationCreator creator = new EmailNotificationCreator();
			var notification = creator.CreateNotification();
			notification.Send("Este es un mensaje de prueba.");

		   	creator = new SMSNotificationCreator();
			notification = creator.CreateNotification();
			notification.Send("Este es un mensaje de prueba.");

			creator = new MessageNotificationCreator();
			notification = creator.CreateNotification();
			notification.Send("Este es un mensaje de prueba.");
		}

	}
}
