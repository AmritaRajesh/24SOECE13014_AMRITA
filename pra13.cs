//13 Write a Program to prints the following series
//0 1 1 2 3 5 8 13 21 34 55

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA
{
    internal class pra13
    {
        public static void Main(string[] args)
        {
            Console.Write("Fibonacci Series: ");
            int a = 0, b = 1;
            Console.Write($"{a} {b} ");
            while (b != 55)
            {
                Console.Write($"{b = a + (a = b)} ");
            }
            Console.WriteLine();
        }

    }
}
