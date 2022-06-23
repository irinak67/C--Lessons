// See https://aka.ms/new-console-template for more informatio


using Lesson_1.Delegate_Event;

class Program
{
    //public delegate int ValueDelegate(int i);

    //public delegate void MyDelegate();
    ////public Action ActionDelegate;

    //public event MyDelegate Event;    //or  public event Action EventAction;


    static void Main(string[] args)
    {
        #region delegate
        //MyDelegate myDelegate = Method1;
        //myDelegate += Method4;
        //myDelegate();

        //MyDelegate myDelegate2 = new MyDelegate(Method4);
        //myDelegate2 += Method4;
        //myDelegate2 -= Method4;
        //myDelegate2.Invoke();

        //MyDelegate myDelegate3 = myDelegate + myDelegate2;
        //myDelegate3.Invoke();

        //var valueDelegate = new ValueDelegate(MethodValue);
        //valueDelegate += MethodValue;
        //valueDelegate += MethodValue;
        //valueDelegate += MethodValue;
        //valueDelegate += MethodValue;

        //valueDelegate((new Random()).Next(10,50));

        ////Action<int, int, string> action = Method1;        // = public delegate void Action(int a,int b, string s);
        //Action action = Method1;
        //action();

        //Predicate<int> predicate;        //public delegate bool Predicate(int value);

        ////Func<string, char, int> func;          //public delegate int Func(string value, char value)
        //Func<int, int> func = MethodValue;
        //if (func != null)  func(7);              // = func?.Invoke(7)


        //Console.ReadLine();
        #endregion

        Person person = new Person()
        {
            Name = "John"
        };
        person.GoToSleep += Person_GoToSleep;
        person.DoWork += Person_DoWork;
        person.TakeTime(DateTime.Parse("21.06.2022 13:59:15"));
        person.TakeTime(DateTime.Parse("21.06.2022 05:15:04"));


        Events events = new Events();
        Operate operate = new Operate();
        operate.Register();
    }

   

    private static void Person_DoWork(object? sender, EventArgs e)
    {
        if (sender is Person)
            Console.WriteLine($"{((Person)sender).Name} is working");
    }

    private static void Person_GoToSleep()
    {
        Console.WriteLine("The man went to bed"); 
    }

    





    //public static int MethodValue(int i)
    //{
    //    Console.WriteLine(i);
    //    return i;
    //}

    //public static void Method1()
    //{
    //    Console.WriteLine("Method1");
    //}

    //public static int Method2()
    //{
    //    Console.WriteLine("Method2");
    //    return 0;
    //}

    //public static void Method3(int i)
    //{
    //    Console.WriteLine("Method3");
    //}

    //public static void Method4()
    //{
    //    Console.WriteLine("Method4");
    //}
}