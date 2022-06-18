// See https://aka.ms/new-console-template for more information
using Linq_1._2_Select;

//IList<int> numbers = new List<int> { 10, 96, 14, 7, 15, 0, 1084, 33, 27, 29, 7, 5, 105};
//Console.WriteLine("Position\tValue");
////foreach (var number in numbers.Where(x => x % 2 == 0))
//foreach (var number in numbers.Select((x, idx) => new {Number = x, Index = idx}).Where(x => x.Number % 2 == 0))
//{
//    Console.WriteLine(number.Index.ToString() + "\t\t" + number.Number.ToString() );
//}



//IEnumerable<string> names = Student.GetAllStudents().Select(s => s.FirstName + " " + s.LastName);

//IEnumerable<string> names = Student.GetAllStudents().SelectMany(s => s.Courses).Distinct();
//       /\
//       ||
//       \/
//IEnumerable<string> names = (from Student in Student.GetAllStudents()
//                            from Courses in Student.Courses
//                            select Courses).Distinct();

//var students = Student.GetAllStudents().SelectMany(s => s.Courses, (s, course) => new { Name = s.FirstName + " " + s.LastName, Course = course });
//       /\
//       ||
//       \/
var students = from student in Student.GetAllStudents()
               from course in student.Courses
               select new { Name = student.FirstName + " " + student.LastName, Course = course };

foreach (var item in students)
{
    Console.WriteLine(item.Name + "\t" + item.Course);
}