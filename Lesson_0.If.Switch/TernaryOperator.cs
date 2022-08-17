using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_0.If.Switch
{
    public class TernaryOperator
    {
        public static void IsMoreOf100()
        {
            Console.WriteLine("Please, insert number:");
            int number = Int32.Parse(Console.ReadLine());

            Console.WriteLine(number > 100 ? "Number is more of 100": "Number is less of 100");
        }
    }
}
