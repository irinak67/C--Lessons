using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class InheritenceSample
    {
        public string animal = "Dog";
        public void GetSound()
        {
            Console.WriteLine("A " + animal + " says Woof-Woof");
        }
    }
    class MyDog : InheritenceSample
    {
        public string name = "Milli";

        public void GetName ()
        {            
            Console.WriteLine("I have a " + animal + ". Her name is " + name);
            //GetSound();
        }
    }
}
