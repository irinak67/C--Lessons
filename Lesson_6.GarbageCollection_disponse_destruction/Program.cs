// See https://aka.ms/new-console-template for more information


//GC.Collect(2);          // דור 2
using Lesson_6.GarbageCollection_disponse_destruction;

Console.WriteLine(GC.GetTotalMemory(false));  //number of bytes currently allocated in managed memory.

for (int i = 0; i < 10000; i++)
{
    

    var obj = (object)i;
    int j = (int)obj;
}

Console.WriteLine(GC.GetTotalMemory(false));

using (var c = new MyClass())           //with IDisposable only
{

}

Console.WriteLine(GC.GetTotalMemory(false));


