// See https://aka.ms/new-console-template for more information

//// value type   Stack
//int i = 5;
//double a = 5.1;
//char c = 'a';
//bool b = false;
//decimal d = 0.5M;
//float f = 5.3f;
//struct

////ref      Heap
//string s = "hjjjnk";
//Array arr;
//Object;


int a = 1;
Foo(a);
Console.WriteLine(a);        // 1

int[] b = new int[1];
b[0] = 1;
Bar(b);
Console.WriteLine(b[0]);     // 5

static void Foo(int a)
{
    a = 5;
}

static void Bar(int[] arr)
{
    arr[0] = 5;
}