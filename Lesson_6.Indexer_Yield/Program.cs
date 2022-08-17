// See https://aka.ms/new-console-template for more information

using Lesson_6.Indexer_Yield;

var cars = new List<Car>()
{
    new Car() { Name = "Ford", Number = "000-00-000" },
    new Car() { Name = "BMW", Number = "111-11-111" },
    new Car() { Name = "Opel", Number = "222-22-222" }
};

var parking = new Parking();

foreach (var car in cars)
{
    parking.Add(car);
}

foreach (var car in parking)
{
    Console.WriteLine(car);
}

foreach (var item in parking)
{
    Console.Write(item + " ");
}
Console.WriteLine();

foreach (var name in parking.GetNames())
{
    Console.WriteLine("Name is: " + name);
}

Console.WriteLine(parking["000-00-000"]?.Name);
Console.WriteLine(parking["111-11-111"]?.Name);
Console.WriteLine(parking["222-22-222"]?.Name);

Console.WriteLine("Please, insert number of new car:");
var num = Console.ReadLine();

parking[1] = new Car() { Name = "Honda", Number = num };

Console.WriteLine(parking[1]);

