using System;

namespace Lesson_1.Interface
{
    class Cyborg : ICar, IPerson
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        int IPerson.Move(int distance)
        {
            return distance / 5;
        }

        int ICar.Move(int distance)
        {
            return distance / 40;
        }
    }
}
