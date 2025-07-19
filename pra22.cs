//22.Write a program to display a pattern like a diamond. 

//    *  

//   ***   

//  *****

// *******

//*********  

// ******* 

//  *****  

//   ***   

//    *

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA
{
    internal class pra22
    {
        public static void Main(string[] args)
        {
            int n = 5;
            for (int i = 1; i <= 2 * n - 1; i++)
            {
                int spaces = Math.Abs(n - i);
                int stars = 2 * (n - spaces) - 1;
                Console.Write(new string(' ', spaces));
                Console.WriteLine(new string('*', stars));
            }
        }
    }
}
