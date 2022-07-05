using System;


namespace Lesson_8.Generic
{
    public class Apple : Product<int>
    {
        public Apple(string name, int volume,int energy) : base(name, volume, energy)
        {
        }
    }
}
