using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface
{
    interface IAnimal
    {
        public string animal { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string sound { get; set; }
        public string food { get; set; }
        void GetAnimal();
        void GetSound();
        void GetFood();

    }
}
