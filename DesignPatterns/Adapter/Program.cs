using Adapter.BusinessLogic;
using Adapter.ConcreteInterfaces;
using Adapter.Interfaces;

Console.WriteLine("Hello, Adapter pattern!");

Adaptee adaptee = new Adaptee();

ITarget target = new AdapterPattern(adaptee);

Console.WriteLine("Adaptee interface is incompatible with the client.");
Console.WriteLine("But with adapter client can call it's method.");

Console.WriteLine(target.GetRequest());

Console.WriteLine("\nOther example Adapter!");

// El sistema original que utiliza notificaciones por email
IEmailNotifier emailNotifier = new EmailNotifier();
emailNotifier.SendEmail("Este es un mensaje de correo electrónico");

// Nuevo sistema de notificación por SMS adaptado para ser utilizado como un notificador de email
SmsNotifier smsNotifier = new SmsNotifier();
IEmailNotifier adaptedSmsNotifier = new SmsToEmailAdapter(smsNotifier);
adaptedSmsNotifier.SendEmail("Este mensaje se enviará como SMS");