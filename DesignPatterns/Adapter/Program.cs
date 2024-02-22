using Adapter.BusinessLogic;
using Adapter.ConcreteInterfaces;
using Adapter.Interfaces;

Console.WriteLine("Hello, Adapter pattern!");

Adaptee adaptee = new Adaptee();

ITarget target = new AdapterPattern(adaptee);

Console.WriteLine("Adaptee interface is incompatible with the client.");
Console.WriteLine("But with adapter client can call it's method.");

Console.WriteLine(target.GetRequest());