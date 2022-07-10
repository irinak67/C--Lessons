// See https://aka.ms/new-console-template for more information

using Lesson_9.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;

var groups = new List<Group>();
var students = new List<Student>();

for (int i = 1; i < 10; i++)
{
    groups.Add(new Group(i, "Group " + i));
}

for (int i = 0; i < 300; i++)
{
    var student = new Student(Guid.NewGuid().ToString().Substring(0, 5), i % 100)
    {
        Group = groups[i % 9]
    }; 
    students.Add(student);
}

////binary
//var binFormatter = new BinaryFormatter();
//using(var file = new FileStream("groups.bin",FileMode.OpenOrCreate))
//{
//    binFormatter.Serialize(file, groups);
//}
//using (var file = new FileStream("groups.bin", FileMode.OpenOrCreate))
//{
//    var newGroups = binFormatter.Deserialize(file) as List<Group>;
//    if(newGroups != null)
//    {
//        foreach (var group in newGroups)
//        {
//            Console.WriteLine(group);
//        }
//    }
//}

//JSON    CODE BLOG
var jsonFormatter = new DataContractJsonSerializer(typeof(List<Student>));
using (var file = new FileStream("students.json", FileMode.Create))
{
    jsonFormatter.WriteObject(file, students);
}
using (var file = new FileStream("students.json", FileMode.OpenOrCreate))
{
    var newStudents = jsonFormatter.ReadObject(file) as List<Student>;
    if (newStudents != null)
    {
        foreach (var student in newStudents)
        {
            Console.WriteLine(student);
        }
    }
}


//JSON       Zionet
JSON_Serialization.RunDe();