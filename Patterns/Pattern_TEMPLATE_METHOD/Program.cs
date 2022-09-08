// See https://aka.ms/new-console-template for more information

using Pattern_TEMPLATE_METHOD;

//Create two types of pie.
var meatPie = new MeatPie();
var applePie = new ApplePie();

//MeatPie
Console.WriteLine(meatPie);
meatPie.Cook();
Console.ReadLine();

//ApplePie
Console.WriteLine(applePie);
applePie.Cook();
Console.ReadLine();
