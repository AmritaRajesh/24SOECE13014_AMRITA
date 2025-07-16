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
            Console.Write("Enter the number of rows for the pyramid:");
            if (int.TryParse(Console.ReadLine(), out int rows) && rows > 0)
            {
                int number = 1;
                for (int i = 1; i <= rows; i++)
                {
                    // Print leading spaces
                    Console.Write(new string(' ', rows - i));
                    // Print numbers
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(number + " ");
                        number++;
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid positive integer.");
            }
        }
    }
}
