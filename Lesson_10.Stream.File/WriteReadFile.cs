using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10.Stream.File
{
    public class WriteReadFile
    {
        //string name;
        //string lastName;
        //int age;
        List<string> nameList = new List<string>();
        List<string> lastNameList = new List<string>();
        List<int> ageList = new List<int>();
        public static void WriteReadMyFile()
        {
            Console.Write("Insert name:\t");
            string name = Console.ReadLine();
            //TODO: 
            //while (true)
            //{
            //    string input = Console.ReadLine();
            //    if (!string.IsNullOrEmpty(input))
            //    {                   
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("The name is incorrect. Please, insert again");
            //    }
            //}
            //string name = input;
            Console.Write("Insert lastName:\t");
            //while (true)
            //{
            //    //string input = Console.ReadLine();
            //    if (!string.IsNullOrEmpty(input))
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("The age is incorrect. Please, insert again");
            //    }
            //}
            string lastName = Console.ReadLine();
            Console.Write("Insert age:\t");
            //while (true)
            //{
            //    string input = Console.ReadLine();
            //    if (Int32.TryParse(input, out int result) && result > 0 && result < 120)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("The age is incorrect. Please, insert again");
            //    }
            //}          
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Name is: {name}, Last Name is: {lastName}, Age is: {age}");

            using (var sw = new StreamWriter("names.txt", true, Encoding.Unicode))
            {
                sw.WriteLine("Your name is: " +  lastName + " " + name +". And you are " + age);
            }

            using (var sr = new StreamReader("names.txt"))
            {
                var text = sr.ReadToEnd();
                Console.WriteLine(text);
            }
        }
        
    }
}
