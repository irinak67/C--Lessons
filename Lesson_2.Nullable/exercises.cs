using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2.Nullable
{
    internal class exercises
    {
        public static void isNullable()
        {
            int? i = null;

            Console.WriteLine(i == null);                   // true
            Console.WriteLine(i.HasValue);                  // false
            Console.WriteLine(i.GetValueOrDefault());       // 0
            Console.WriteLine(i.GetValueOrDefault(3));      // 3
            Console.WriteLine(i ?? 55);                     // 55
            Console.WriteLine(i.Value);                     // InvalidOperationExeption

        }

        public static void isNotNullable()
        {
            int a = 5;
            int? b = null;
            int? result = a + b;

            Console.WriteLine(result);      // null
            Console.WriteLine(a == b);      // false
            Console.WriteLine(a > b);       // false
            Console.WriteLine(a < b);       // false

            int? c = 22;
            int? result1 = a + c;

            Console.WriteLine("\n" + result1);      // 27
            Console.WriteLine(a == c);      // false
            Console.WriteLine(a > c);       // false
            Console.WriteLine(a < c);       // true
        }
    }
}
