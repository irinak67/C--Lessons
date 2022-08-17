using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4.ExtensionMethod
{
    public sealed class Road
    {
        public string Number { get; set; }
        public string Lenght { get; set; }

        public override string ToString()
        {
            return $"Road {Number} with a total length {Lenght}";
        }


    }
}
