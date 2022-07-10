using System;

namespace Lesson_1.Interface
{
    class CarBMW : ICar
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public int Move(int distance)
        {
            return distance / 120;
        }
    }
}
