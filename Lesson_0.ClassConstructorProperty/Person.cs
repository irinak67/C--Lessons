using System;

namespace Lesson_0.ClassConstructorPropertyRecursion
{
    public class Person
    {
        /// <summary>
        /// property
        /// </summary>
         
        public string SecondName { get; set; }
        public string FirstName { get; set; }

        public string FullName
        {
            get 
            { 
                return FirstName + " " + SecondName; 
            }
        }
        public string ShortName 
        { 
            get
            {
                return $"{SecondName} {FullName.Substring(0,1)}." ;
            }
        }
        public int X { get; set; }
        public int Y { get; set; }

        #region property
        //private string _name;

        ////public string GetName()
        ////{
        ////    return _name; 
        ////}
        ////public void SetName(string name)
        ////{
        ////    if (string.IsNullOrEmpty(name))
        ////    {
        ////        throw new ArgumentNullException("incorrect name value");
        ////    }
        ////    _name = name;
        ////}

        //public string Name 
        //{ 
        //    get 
        //    { 
        //        return _name; 
        //    } 
        //    set 
        //    {
        //        if (string.IsNullOrEmpty(value))
        //        {
        //            throw new ArgumentNullException("incorrect name value");
        //        }
        //        _name = value; }

        //}
        #endregion


        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="secondname"></param>
        
        public Person (string firstname, string secondname)
        {
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(secondname))
            {
                throw new ArgumentException("incorrect name");
            }    
            else
            {
                FirstName = firstname;
                SecondName = secondname;
                X = 0;
                Y = 0;
            }            
        }

        public string Run()
        {
            var rnd = new Random();
            X += rnd.Next(-2, 2);
            Y += rnd.Next(-2, 2);

            return $"{FirstName } ({X},{Y})";
        }
        public string Run(int x)
        {
            var rnd = new Random();
            X += x;
            Y += rnd.Next(-2, 2);

            return $"{FirstName} ({X},{Y})";
        }
        public string Run(int x, int y)
        {
            var rnd = new Random();
            X += x;
            Y += y;

            return $"{FirstName} ({X},{Y})";
        }
    }
}
