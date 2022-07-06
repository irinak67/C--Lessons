// See https://aka.ms/new-console-template for more information

int[] array = new int[10];
array[0] = 1;
array[1] = 2;
array[2] = 3;
array[9] = 5;

Console.WriteLine($"{array[0]},{array[9]}");

int[,] array1 = new int[5, 5];
array1[0,0] = 6;
array1[4,4] = 7;

Console.WriteLine(array1[4,4]);

List<int> list = new List<int>();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);

List<int> list1 = new List<int>()
{ 
    1, 2, 3, 4, 5, 6, 7
};

list1.AddRange(list);

Console.WriteLine(list1.Count);

Console.WriteLine(Days.Wednesday);

enum Days
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

