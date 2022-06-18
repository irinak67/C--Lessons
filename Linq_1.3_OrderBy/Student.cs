using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_1._3_OrderBy
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public ICollection<string> Courses { get; set; }

        public static ICollection<Student> GetAllStudents()
        {
            List<Student> result = new List<Student>()
            {
                new Student
                {
                    FirstName = "Alex",
                    LastName = "Smit",
                    Gender = "Male",
                    Courses = new Collection<string> {"C#","Java","C+"}
                },
                new Student
                {
                    FirstName = "Mary",
                    LastName = "Krafft",
                    Gender = "Female",
                    Courses = new Collection<string> {"Phyton","Java","C++"}
                },
                new Student
                {
                    FirstName = "John",
                    LastName = "Mall",
                    Gender = "Male",
                    Courses = new Collection<string> {"Node","MongoDB","Cloud"}
                },
                new Student
                {
                    FirstName = "Helen",
                    LastName = "Fan",
                    Gender = "Female",
                    Courses = new Collection<string> {"C++","JavaScript","MySQL"}
                }
            };
            return result;
        }

    }
}
