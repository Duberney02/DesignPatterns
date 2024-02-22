using FactoryMethod.BusinessLogic;

Console.WriteLine("Hello, FactoryMethod!");

new Client().Main();

Console.WriteLine("\nExample notifications!");

new ClientNotifications().Execute();
