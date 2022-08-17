// See https://aka.ms/new-console-template for more information

using Lesson_1.Interface;

var cars = new List<ICar>();
cars.Add(new CarBMW());
cars.Add(new CarOpel());

foreach (var car in cars)
{
    Console.WriteLine(car.Move(600));
}

Cyborg cyborg = new Cyborg();
Console.WriteLine(((ICar)cyborg).Move(100));
Console.WriteLine(((IPerson)cyborg).Move(100));