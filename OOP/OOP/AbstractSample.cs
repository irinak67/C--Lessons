using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class AbstractSample
    {
        public abstract void GetNameOfCourse();
        public void GetStatus()
        {
            Console.WriteLine("Is begin");
        }

    }
    class CourseStart : AbstractSample
    {
        public override void GetNameOfCourse()
        {
            Console.WriteLine("Course C#");
        }
    }

}
