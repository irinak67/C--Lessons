using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Car
    {
        public string model;
        public string color = "blue";
        public int year;
    }

    class MyClass
    {
        public string color = "red";   //field
        public int maxSpeed = 200;     //field

        public void fullThrottle()      //method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }

  
}
