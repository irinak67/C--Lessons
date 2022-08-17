using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Car_constructors
    {
        public string model = "CH-R";
        public int year;
        public string color;
        public Car_constructors(int modelYear, string modelColor)    //class constructor for class Car_constructors
        {            
            year = modelYear;
            color = modelColor;
        }
    }
}
