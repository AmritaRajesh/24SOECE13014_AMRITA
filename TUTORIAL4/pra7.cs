//7 :  Refer given output and find out error code and correct it.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13014_AMRITA.TUTORIAL4
{
    sealed class A
    {
        public int x;
        public int y;
    }

    class SealedTest2
    {
        static void Main()
        {
            A sc = new A();

            sc.x = 110;
            sc.y = 150;

            Console.WriteLine("x = {0}, y = {1}", sc.x, sc.y);
        }
    }
}
