using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using GeometryClassLibrary.ConcreteClasses;
using System.Numerics;

var featureManagement = new Dictionary<string, string> { { "FeatureManagement:Square", "true" }, { "FeatureManagement:Rectangle", "false" }, { "FeatureManagement:Triangle", "true" } };

IConfigurationRoot configuration = new ConfigurationBuilder().AddInMemoryCollection(featureManagement).Build();

var services = new ServiceCollection();
services.AddFeatureManagement(configuration);
var serviceProvider = services.BuildServiceProvider();

var featureManager = serviceProvider.GetRequiredService<IFeatureManagerSnapshot>();


if (await featureManager.IsEnabledAsync("Rectangle"))
{
    var squareFunctionality = new Rectangle(2,4);
    squareFunctionality.CalculatePerimeter();
    squareFunctionality.CalculateArea();
}

if (await featureManager.IsEnabledAsync("Triangle"))
{
    var squareFunctionality = new Triangle(1,2,3);
    squareFunctionality.CalculatePerimeter();
    squareFunctionality.CalculateArea();
}

string msg = "Select a shape (";

if(await featureManager.IsEnabledAsync("Square")){
    msg += "square,";
}
if (await featureManager.IsEnabledAsync("Rectangle")){
    msg += "rectangle";
}
if (await featureManager.IsEnabledAsync("Triangle")){
    msg += "triangle)";
}
Console.WriteLine(msg);

string shapeChoice = Console.ReadLine().ToLower();

if (shapeChoice == "square")
{
    
    if (await featureManager.IsEnabledAsync("Square"))
    {
        Console.WriteLine("Give length ");
        int value = Convert.ToInt32(Console.ReadLine());
        var squareFunctionality = new Square(value);
        Console.WriteLine($"perimeter is {squareFunctionality.CalculatePerimeter()}");
        Console.WriteLine($"area is {squareFunctionality.CalculateArea()}");
    }
}

if (shapeChoice == "rectangle")
{

    if (await featureManager.IsEnabledAsync("Rectangle"))
    {
        Console.WriteLine("Give length and breadth seperated by comma (,) [ ex: 2,3 ] ");
        string[] rawValue = Console.ReadLine().Split(",");
        int length = Convert.ToInt32(rawValue[0]);
        int breadth = Convert.ToInt32(rawValue[1]);

        var rectangleFunctionality = new Rectangle(length,breadth);

        Console.WriteLine($"perimeter is {rectangleFunctionality.CalculatePerimeter()}");
        Console.WriteLine($"area is {rectangleFunctionality.CalculateArea()}");
    }
}

if (shapeChoice == "triangle")
{

    if (await featureManager.IsEnabledAsync("Triangle"))
    {
        Console.WriteLine("Give 3 sides seperated by comma (,) [ ex: 2,3, 4 ]");
        string[] rawValue = Console.ReadLine().Split(",");
        int a = Convert.ToInt32(rawValue[0]);
        int b = Convert.ToInt32(rawValue[1]);
        int c = Convert.ToInt32(rawValue[2]);

        var triangleFunctionality = new Triangle(a, b, c);
        Console.WriteLine($"perimeter is {triangleFunctionality.CalculatePerimeter()}");
        Console.WriteLine($"area is {triangleFunctionality.CalculateArea()}");
    }
}
