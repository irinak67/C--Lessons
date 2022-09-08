using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8.Generic
{
    public class Product<T>
    {
        public string Name { get; set; }
        public int Volume { get; set; }
        public int Energy { get; set; }

        public Product(string name, int volume, int energy)
        {
            if (string.IsNullOrEmpty(nameof(name)))
            {
                throw new ArgumentNullException(nameof(name));
            }
            else if (volume <= 0)
            {
                throw new ArgumentException(nameof(volume));
            }
            else if (energy < 0)
            {
                throw new ArgumentException(nameof(energy));
            }
            else
            {
                Name = name;
                Volume = volume;
                Energy = energy;
            }
              
        }
    }
}
