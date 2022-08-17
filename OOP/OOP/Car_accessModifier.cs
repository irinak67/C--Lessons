using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{    
    class Car_accessModifier
    {
        public int year = 2021;
        private string name = "Honda";
        protected string color = "Blue";
        internal string model = "Civic";
        public void GetYear()
        {
            Console.WriteLine("Year is: " + year);
        }
        protected void GetColor()
        {
            Console.WriteLine("Color is: " + color);
        }

        private void GetName()
        {
            Console.WriteLine("Name is: " + name);
        }

        internal void GetModel()
        {
            Console.WriteLine("Model is: " + model);
        }

        
    }

}
