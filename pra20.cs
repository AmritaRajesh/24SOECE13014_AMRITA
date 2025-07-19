//20.Write a program to make a pyramid pattern with numbers increased by 1.

//    1   

//   2 3  

//  4 5 6

//7 8 9 10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA
{
    internal class pra20
    {
        public static void Main(string[]args)
        {
            int m = 3;
            int a = 1;
            for (int i = 1; i < 5; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    System.Console.Write(" ");
                }
                m--;
                for (int j = 1; j <= i; j++)
                {
                    System.Console.Write(a + " ");
                    a++;
                }
                System.Console.WriteLine();
            }
        }
    }
}
