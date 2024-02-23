using Builder.BusinessLogic;
using Builder.ConcreteInterfaces;

Console.WriteLine("Hello, Builder pattern!");

var director = new Director();
var builder = new ConcreteBuilder();
director.Builder = builder;

Console.WriteLine("Standard basic product:");
director.BuildMinimalViableProduct();
Console.WriteLine(builder.GetProduct().ListParts());

Console.WriteLine("Standard full featured product:");
director.BuildFullFeaturedProduct();
Console.WriteLine(builder.GetProduct().ListParts());

// Remember, the Builder pattern can be used without a Director
// class.
Console.WriteLine("Custom product:");
builder.BuildPartA();
builder.BuildPartC();
Console.Write(builder.GetProduct().ListParts());

Console.WriteLine("\nExample Builder Computer!");
var computerBuilder = new ComputerBuilder();
Computer computer = computerBuilder
	.AddProcessor("Intel Core i7")
	.AddRAM("16GB")
	.AddHardDisck("1TB SSD")
	.AddCraphicCard("NVIDIA RTX 3080")
	.Build();
