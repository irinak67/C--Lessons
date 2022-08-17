using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class PolyProperties
    {
        public int x = 3;
        public int y = 5;
        public int result;
        public virtual int X 
        { 
            get => x;
            set { if(value != 0) x = value; } 
        }

        public void aaa()
        {
            bbb(0, 15);
        }
        public virtual void bbb(int X, int y)
        {
            result = X + y;
            Console.WriteLine(X + " + " + y + " = " + result);
        }
    }
    class Operation : PolyProperties 
    {
        public override int X
        {
            get => base.X;
            set { if (value == 0) base.X = value + 10; }
        }
        public override void bbb(int X, int y)
        {
            result = X * y;
            Console.WriteLine(X + " * " + y + " = " + result);
        }
    }
}

