using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA
{
    internal class demo
    {
        public static void Main(String[] args)
        {
            int a = 5;
            int b = 5;
            int res = a++ + b++ + ++b;
            Console.WriteLine(res);
        }

    }
}
