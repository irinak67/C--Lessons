using System;

namespace Lesson_0.If.Switch
{
    public class FindIfMax
    {
        public static void IsMax()
        {
            Console.WriteLine("Please, insert number1:");
            int number1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please, insert number2:");
            int number2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please, insert number3:");
            int number3 = Int32.Parse(Console.ReadLine());
            int maxNumber;

            if (number1 > number2 && number1 > number3)
                maxNumber = number1;

            else if (number2 > number1 && number2 > number3)
                maxNumber = number2;

            else
                maxNumber = number3;

            Console.WriteLine(maxNumber);
        }
    }
}
