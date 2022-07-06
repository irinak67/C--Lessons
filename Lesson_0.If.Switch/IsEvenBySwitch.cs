using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_0.If.Switch
{
    public class IsEvenBySwitch
    {
        public static void IsEven()
        {
            Console.WriteLine("Please, insert number:");
            int number = Int32.Parse(Console.ReadLine());

            switch (number % 2 == 0)
            {
                case true:
                    Console.WriteLine("Your number is even");
                    break;
                case false:
                    Console.WriteLine("Your number isn't even");
                    break;

            }
        }
    }
}
