using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface
{
    internal class Animals_interfaces: IAnimal
    {
        public string animal { get; set; }
        public string name { get; set; }
        public int age { get ; set ; }
        public string sound { get; set; }
        public string food { get; set; }

        public void GetAnimal()
        {
            string animal = "dog";
            string name = "Milli";
            int age = 12;
            Console.WriteLine($"I love my {animal}. Her name is {name}. She is {age} year old");
        }

        public void GetSound()
        {
            string animal = "dog";
            string sound = "Woof-Woof";
            Console.WriteLine($"My {animal} says '{sound}'");
        }

        public void GetFood()
        {
            string food = "meat";
            Console.WriteLine($"Dogs love to eat {food}");
        }
    }
}
