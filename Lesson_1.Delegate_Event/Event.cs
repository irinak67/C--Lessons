using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1.Delegate_Event
{
    internal class Event
    {
        class buttonPressed
        {
            bool buttonPressedCondition = false;
            public delegate bool ButtonPressedDelegate(bool bp);
            public event ButtonPressedDelegate ButtonPressedEvent;

        }
    }
}
