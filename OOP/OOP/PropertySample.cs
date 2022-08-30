using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class PropertySample
    {
        private string name;
        private int age;
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }

        public void Run()
        {
            PropertySample person = new PropertySample();
            person.name = "Tom";
            person.age = 25;
            Console.WriteLine("My name is " + person.Name + " and I'm " + person.Age);
        }
    }
}
