// See https://aka.ms/new-console-template for more information

using System.Text;

namespace Lesson_11.Async.Await.Thread
{

    class Program
    {
        public static object locker = new object();
        static void Main(string[] args)
        {

            #region Thread
            //Thread thread = new Thread(new ThreadStart(DoWork));
            //thread.Start();

            //Thread thread2 = new Thread(new ParameterizedThreadStart(DoWork2));
            //thread2.Start(int.MaxValue);

            //int j = 0;
            //for (int i = 0; i < int.MaxValue; i++)
            //{
            //    j++;
            //    if (j % 10000 == 0)
            //    {
            //        Console.WriteLine("Main");
            //    }
            //}
            #endregion


            #region async/await

            //Console.WriteLine("Begin Main");

            //DoWorkAsync(100);

            //Console.WriteLine("Continue Main");

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Main");
            //}
            //Console.WriteLine("End Main");

            //static async Task DoWorkAsync(int max)
            //{
            //    Console.WriteLine("Begin Async");
            //    await Task.Run(() => DoWork(max));
            //    Console.WriteLine("End Async");
            //}
            #endregion


            var result = SaveFileAsync("text.txt");
            Console.ReadLine();
            Console.WriteLine(result.Result);
        }
        static async Task<bool> SaveFileAsync(string path)
        {
            var result = await Task.Run(() => SaveFile(path));
            return result;
        }

        static bool SaveFile(string path)
        {

            lock (locker)       // доступ только для одного в данное время
            {
                Random rnd = new Random();
                string text = "";
                for (int i = 0; i < 50000; i++)
                {
                    text += rnd.Next().ToString() + ", ";
                }
                using (var sw = new StreamWriter(path, false, Encoding.UTF8))
                {
                    sw.WriteLine(text);
                }
            }          

            return true;
        }

        static void DoWork(int max)
        {
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine("DoWork");
            }
        }

        static void DoWork2(object max)
        {

            int j = 0;
            for (int i = 0; i < (int)max; i++)
            {
                j++;
                if (j % 10000 == 0)
                {
                    Console.WriteLine("DoWork 2");
                }
            }
        }
        
    }
}