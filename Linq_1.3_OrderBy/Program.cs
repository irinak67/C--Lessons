// See https://aka.ms/new-console-template for more information

using Linq_1._3_OrderBy;

//var students = Student.GetAllStudents().OrderBy(s => s.LastName);     //from A to Z
//var students = Student.GetAllStudents().OrderByDescending(s => s.LastName);   //from Z to A  descending 
var students = from student in Student.GetAllStudents()
               orderby student.LastName ascending
               select student;                             // from A to Z - ascending,  from Z to A - descending

foreach (var item in students)
{
    Console.WriteLine(item.LastName + " " + item.FirstName);
}