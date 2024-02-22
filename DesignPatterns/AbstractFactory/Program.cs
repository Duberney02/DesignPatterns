using AbstractFactory.BusinessLogic;

Console.WriteLine("Hello, AbstractFactory!");

new Client().Main();

Console.WriteLine("\nExample Furniture!");

new ClientFurniture().Execute();