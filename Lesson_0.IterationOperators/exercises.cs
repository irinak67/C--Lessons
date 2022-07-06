using System;

namespace Lesson_0.IterationOperators
{
    public class Exercises
    {
        public static void ActionsWithCollections()
        {
            List<int> list = new List<int>();
            int sum = 0;           
            int multiply = 1;
            for (int i = 0; i < 15; i++)
            {
                Console.Write("Please, insert your number: \t");                
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    list.Add(number);
                }
                catch(FormatException)
                {
                    Console.WriteLine("Input uncorrected. Please insert correct number: \t");                    
                }
            }
            Console.WriteLine();

            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            int j = 1;
            int subtraction = list[0];
            while (j < list.Count)
            {
                subtraction -= list[j];
                j++;
            }

            int k = 0;
            do
            {
                multiply *= list[k];
                k++;
            }
            while (k < list.Count);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nThe sum is: \t\t" + sum);
            Console.WriteLine("The subtraction is: \t" + subtraction);
            Console.WriteLine("The multiply is: \t" + multiply);
        }
    }
}
