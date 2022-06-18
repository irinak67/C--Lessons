// See https://aka.ms/new-console-template for more information


using Linq_1._4_ThenBy;

//var students = Student.GetAllStudents().OrderBy(s => s.LastName).ThenBy(s => s.FirstName);  //ThenByDescending - reverse sort
//     /\
//     ||
//     \/
//var students = from student in Student.GetAllStudents()
//               orderby student.LastName, student.FirstName
//               select student;

//var students = Student.GetAllStudents().Reverse();    // From end to start
//     /\
//     ||
//     \/
var students = (from student in Student.GetAllStudents()
               select student).Reverse();

foreach (var item in students)
{
    Console.WriteLine(item.LastName + " " + item.FirstName);
}