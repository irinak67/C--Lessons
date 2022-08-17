using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8.Generic
{
    public class Eating<T> 
        where T : Product<int>
    {
        public int Volume { get; private set; }

        public void Add(T product)
        {
            Volume += product.Volume * product.Energy;
        }
    }
}
