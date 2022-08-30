// See https://aka.ms/new-console-template for more information

using Lesson_0.ClassConstructorPropertyRecursion;

static int Factorial(int value)
{
    if (value <= 1)
    {
        return 1;
    }
    else
    {
        return value * Factorial(value - 1);
    }
    
}

static int Fibonacci(int number)
{    
    if (number == 0 || number == 1)
    {      
       return number;
    }
    else
    {            
        return Fibonacci(number - 1) + Fibonacci(number - 2);       
    }
    
}

//without constructor
//Person p = new Person();
////p.SetName("Jon");
////Console.WriteLine(p.GetName());
//p.FirstName = "Jon";
//p.SecondName = "Smith";

//with constructor
Person p1 = new Person("Jon", "Smith");
Person p2 = new Person("Mary", "Blank");
Person p3 = new Person("Garry", "Krus");

for (int i = 0; i < 10; i++)
{
    var position1 = p1.Run();
    Console.WriteLine(position1);

    var position2 = p2.Run(5);
    Console.WriteLine(position2);

    var position3 = p3.Run(2, 1);
    Console.WriteLine(position3);
}

Console.WriteLine(p1.FullName);
Console.WriteLine(p2.ShortName);
Console.WriteLine(Factorial(3));
for (int i = 0; i <= 10; i++)
{
    Console.Write($"{Fibonacci(i)} ");
}