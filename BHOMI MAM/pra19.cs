//19.Write a program to make such a pattern as a pyramid with an asterisk. 

//   *   

//  * *  

// * * *

//* * * *

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA
{
    internal class pra19
    {
        public static void Main(string[] args)
        {
            int m = 3;
            for (int i = 1; i < 5; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    System.Console.Write(" ");
                }
                m--;
                for (int j = 1; j <= i; j++)
                {
                    System.Console.Write("* ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
