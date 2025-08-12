//18 Write a program to make such a pattern like a right angle triangle with the number increased by 1.

//The pattern like :

//1

//2 3

//4 5 6

//7 8 9 10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA
{
    internal class pra18
    {
        public static void Main(string[] args)
        {
            int m = 1;
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    System.Console.Write(m++ + " ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
