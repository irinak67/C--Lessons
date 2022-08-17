using System;
using System.Collections;

namespace Lesson_4.ExtensionMethod
{
    public static class Helper
    {
        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }

        public static bool IsDivideBy(this int i, int j)
        {
            return i % j == 0;
        }

        public static string ConvertToString(this IEnumerable collection)
        {
            var result = "";

            foreach (var item in collection)
            {
                result += item.ToString() + ", \n";
            }

            return result;
        }

        public static Road CreateRandomRoad(this Road road, int min, int max)
        {
            var rnd = new Random(Guid.NewGuid().ToByteArray().Sum(x => x));
            road.Number = "S" + rnd.Next(1, 100);            
            road.Lenght = (rnd.Next(min, max)).ToString();
            return road;
        }
    }
}
