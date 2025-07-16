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
            Console.Write("Enter the number of rows for the diamond (half):");
            if (int.TryParse(Console.ReadLine(), out int rows) && rows > 0)
            {
                // Upper part of the diamond
                for (int i = 1; i <= rows; i++)
                {
                    Console.Write(new string(' ', rows - i));
                    Console.WriteLine(new string('*', 2 * i - 1));
                }
                // Lower part of the diamond
                for (int i = rows - 1; i >= 1; i--)
                {
                    Console.Write(new string(' ', rows - i));
                    Console.WriteLine(new string('*', 2 * i - 1));
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid positive integer.");
            }
        }
    }
}
