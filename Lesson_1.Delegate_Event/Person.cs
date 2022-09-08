using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1.Delegate_Event
{
    class Person
    {
        public event Action GoToSleep;
        public event EventHandler DoWork;

        public string Name { get; set; }

        public void TakeTime(DateTime now)
        {
            if (now.Hour < 8 || now.Hour > 21)
                GoToSleep?.Invoke();
            else
                DoWork?.Invoke(this, null);
        }
    }
}
