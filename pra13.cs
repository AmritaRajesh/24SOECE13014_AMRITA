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
            int n = 11; // Number of terms in the Fibonacci series
            int a = 0, b = 1, c;
            Console.Write("Fibonacci Series: ");
            Console.Write(a + " " + b + " ");
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            Console.WriteLine();
        }

    }
}
