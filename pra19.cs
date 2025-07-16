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
            Console.Write("Enter the number of rows for the pyramid:");
            if (int.TryParse(Console.ReadLine(), out int rows) && rows > 0)
            {
                for (int i = 1; i <= rows; i++)
                {
                    // Print leading spaces
                    Console.Write(new string(' ', rows - i));
                    // Print asterisks
                    Console.WriteLine(new string('*', i * 2 - 1));
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid positive integer.");
            }
        }
    }
}
