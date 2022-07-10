using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1.Interface
{
    class CarOpel : ICar
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public int Move(int distance)
        {
            return distance / 80;
        }
    }
}
