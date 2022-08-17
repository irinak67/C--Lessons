// See https://aka.ms/new-console-template for more information


using Lesson_4.ExtensionMethod;

Console.WriteLine("Insert number: ");
var input = Console.ReadLine();

if(int.TryParse(input, out int result))
{
    //var isEven = IsEven(result);
    
    if(result.IsEven())
    {
        Console.WriteLine($"{result} - is even number.");
    }
    else
    {
        Console.WriteLine($"{result} - is odd number.");
    }

    int h = 182;
    h.IsDivideBy(7);
    if (h.IsDivideBy(7))
    {
        Console.WriteLine($"{h} - is Divide by 7.");
    }
    else
    {
        Console.WriteLine($"{h} - isn't Divide by 7.");
    }

    var roads = new List<Road>();
    for (int i = 0; i < 10; i++)
    {
        var road = new Road();
        road.CreateRandomRoad(1000, 10000);
        roads.Add(road);
    }

    var roadsName = roads.ConvertToString();
    Console.WriteLine(roadsName);
}
else
{
    Console.WriteLine("It's not integer value");
}


