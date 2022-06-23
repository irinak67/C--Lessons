//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Lesson_1.Delegate_Event
{
    internal class Events
    {        
            bool buttonPressedCondition = false;
            public delegate void ButtonPressedDelegate(bool bp);
            public event ButtonPressedDelegate ButtonPressedEvent;

            public void Run()
            {
                if (!buttonPressedCondition)
                {
                    buttonPressedCondition = true;
                }
                    
            }
       
    }

    public class Operate
    {
        Events events = new Events();
        Teacher teacher = new Teacher();
        Student student = new Student();

        public void Register()
        {
            events.ButtonPressedEvent += teacher.UpdateTeacherButtonPressed;
            events.ButtonPressedEvent += student.UpdateStudentButtonPressed;
            
            events.Run();
        }
       
    }


    public class Teacher
    {
        public void UpdateTeacherButtonPressed(bool bp)
        {
            Console.WriteLine("Exam started");            
        }       
    }

    public class Student
    {
        public void UpdateStudentButtonPressed(bool bp)
        {
            Console.WriteLine("Student taking an exam");
        }        
    }
}
