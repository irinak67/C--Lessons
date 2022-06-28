// See https://aka.ms/new-console-template for more information

using Lesson_3.Boxing_Unboxing;

int a = 1;
object b = a;               //boxing
int c = (int)b;             //unboxing

Point point = new Point { X = 2, Y = 4 };
Print(point);

static void Print(IPrintable printable)
{
    printable.Print();
}

struct Point : IPrintable
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Print()
    {
        Console.WriteLine($"X:{ X }\tY: { Y }"); 
    }
}