//17.Write a Program to generate following output.

//1

//1 2

//1 2 3

//1 2 3 4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA
{
    internal class pra17
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    System.Console.Write(j + " ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
