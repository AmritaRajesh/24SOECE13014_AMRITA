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
            Console.Write("Enter the number of rows for the triangle:");
            if (int.TryParse(Console.ReadLine(), out int rows) && rows > 0)
            {
                int number = 1;
                for (int i = 1; i <= rows; i++)
                {
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
