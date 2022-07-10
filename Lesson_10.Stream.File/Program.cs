// See https://aka.ms/new-console-template for more information

using Lesson_10.Stream.File;
using System.Text;

////Console.OutputEncoding = Encoding.Unicode;
//using (var sw = new StreamWriter("test.txt", true, Encoding.Unicode))
//{
    
//    sw.WriteLine("Hello, World!!!");
//    sw.WriteLine("Hello, User!!!");
//    //sw.WriteLine("שלום");
//    sw.WriteLine("Привет!!!");
//}
// using(var sr = new StreamReader("test.txt", Encoding.Unicode))
//{
//    while(!sr.EndOfStream)
//    {
//        Console.WriteLine(sr.ReadLine() + " End of line");
//    }
    
//    sr.DiscardBufferedData();                    // clear the buffer
//    sr.BaseStream.Seek(0, SeekOrigin.Begin);     //to start of file

//    var text = sr.ReadToEnd();
//    Console.WriteLine(text);
//}

WriteReadFile.WriteReadMyFile();