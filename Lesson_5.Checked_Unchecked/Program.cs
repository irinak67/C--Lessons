// See https://aka.ms/new-console-template for more information


int a = int.MaxValue;   // 2147483647
a += 1;                 // -2147483648
Console.WriteLine(a);

int b = int.MinValue;   // -2147483648
b -= 1;                 // 2147483647
Console.WriteLine(b);

double d = 1.0 / 0.0; 
Console.WriteLine(double.IsInfinity(d));    // true

double e = 0.0 / 0.0;
Console.WriteLine(double.IsNaN(e));         // true

double f = double.MaxValue + double.MaxValue;
Console.WriteLine(double.IsInfinity(f));    // true

decimal g = decimal.MaxValue;
decimal h = decimal.MinValue;
//decimal i = g + h;               // overflowExeption
decimal i = unchecked(g + h);

byte aggresion = 1;
byte democracyModifier = 2;

try
{
    aggresion = checked((byte)(aggresion - democracyModifier));
}
catch(OverflowException)
{
    Console.WriteLine("OverflowExeption");
}

