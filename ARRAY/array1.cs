//1. Write a C# Sharp program that stores elements in an array and prints them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA.ARRAY
{
    internal class array1
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[5]; // Array to store 5 integers

            Console.WriteLine("Enter 5 numbers:");

            // Store elements in the array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nThe elements you entered are:");

            // Print elements of the array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Element {0}: {1}", i + 1, numbers[i]);
            }
        }
    }
}
