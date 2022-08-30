using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class PolySample
    {
        public int x;
        public int y;
        public int result;

        public void aaa()
        {
            bbb(8, 15);
        }
        public virtual void bbb(int x, int y)
        {
            result = x + y;
            Console.WriteLine(x + " + " + y + " = " + result);
        }
    }
    class Multi : PolySample
    {
        public override void bbb(int x, int y)
        {
            result = x * y;
            Console.WriteLine(x + " * " + y + " = " + result); 
        }
    }
}
