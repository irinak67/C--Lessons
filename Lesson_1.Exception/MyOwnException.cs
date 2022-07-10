using System;

namespace Lesson_1.Exception
{
    class MyOwnException : IOException
    {
        public MyOwnException() : base("This is my exception")
        { 
        }
        public MyOwnException(string message) : base(message)
        {
        }
    }
}
