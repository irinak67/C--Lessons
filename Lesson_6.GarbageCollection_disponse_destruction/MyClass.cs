using System;


namespace Lesson_6.GarbageCollection_disponse_destruction
{
    public class MyClass : IDisposable
    {
        public MyClass() { }
        ~MyClass() { }     // destration

        public void Dispose()
        {
           GC.Collect();
        }
    }

    
}
