using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1.Interface
{
    class NewObject : IObject
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Create()
        {
            throw new NotImplementedException();
        }
    }
}
