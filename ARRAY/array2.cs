//2. Write a program of sorting an array.
//Declare single dimensional array and accept 5 integer values from the user.
//Then sort the input in ascending order and display output.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA.ARRAY
{
    internal class array2
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[5];
            List<int> numberList = new List<int>();

            // Accept 5 integers from the user
            Console.WriteLine("Enter 5 numbers:");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"Number {i + 1}: ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                    numberList.Add(numbers[i]);
                }

                // Sort the array in ascending order
                Array.Sort(numbers);

                // Display sorted array
                Console.WriteLine("\nSorted numbers in ascending order:");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
        }
    }
}
