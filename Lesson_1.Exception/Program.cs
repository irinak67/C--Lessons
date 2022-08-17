// See https://aka.ms/new-console-template for more information

using Lesson_1.Exception;

int i = 5;
try
{
    //    double j = i / 0;

    //    int a = 200000000;
    //    int b = 200000000;
    //    int c = checked(a * b);

    //throw new DivideByZeroException();
    //throw new DivideByZeroException("text to print");
    //throw new ArgumentNullException("i","text to print");
    throw new MyOwnException();
}
catch (MyOwnException ex)
{
    Console.WriteLine(ex.Message);
}
catch (DivideByZeroException ex) when (i == 5)
{
    Console.WriteLine(ex.Message + " (i = 5)");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{    
    Console.WriteLine(ex.Message); 
}

finally
{
    Console.WriteLine("Done");
}