//16  Write a program to display a pattern like a right angle triangle using an asterisk

//The pattern like :

//*

//**

//***

//****

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA
{
    internal class pra16
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of rows for the triangle:");
            if (int.TryParse(Console.ReadLine(), out int rows) && rows > 0)
            {
                for (int i = 1; i <= rows; i++)
                {
                    Console.WriteLine(new string('*', i));
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid positive integer.");
            }
        }
    }
}
