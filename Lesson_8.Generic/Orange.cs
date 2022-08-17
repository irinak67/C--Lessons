using System;

namespace Lesson_8.Generic
{
    public class Orange : Product<int>
    {
        public Orange(string name, int volume, int energy) : base(name, volume, energy) 
        {
        }
    }
}
