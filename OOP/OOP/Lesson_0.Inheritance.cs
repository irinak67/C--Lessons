using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Lesson_0
    {
    }
    class A
    {
        
        public virtual int GetNum ()
        {
            int number = 5;
            Console.WriteLine($"Class A: number is: {number}");
            return number;
        }
        public virtual string GetString()
        {
            string str = "My name is Irina";
            Console.WriteLine($"Class A.GetString : {str}");
            return str;
        }
    }
    class B: A
    {
        public override int GetNum ()
        {
            int number = 8;
            Console.WriteLine($"Class B: number is: {number}");
            return number;
        }
        public override string GetString()
        {
            string str = "I'm from Israel";
            Console.WriteLine($"Class B.GetString : {str}");
            return str;
        }
    }
    class C: B
    {
        //class factory design pattern
        private static int count = 0;
        private C()
        {
        }
        public static C Create()
        {
            if (count <= 3)
            {
                count++;
                return new C();
            }
            else
                return null;
            
        }

        //regular class
        public override int GetNum()
        {
            int number = 15;
            Console.WriteLine($"Class C: number is: {number}");
            Console.WriteLine($"Class C: number from base is: {base.GetNum()}");
            return number;
        }
        public override string GetString()
        {
            string str = "I love my dog";
            Console.WriteLine($"Class C.GetString : {str}");
            return str;
        }
        public void Print()
        {
            Console.WriteLine("Hello!");
        }     
        
    }
}
