/* 9 : Given an array A containing 2*N+2 positive numbers, out of which 2*N numbers exist in pairs whereas the
other two number occur exactly once and are distinct.Find the other two numbers.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA.TUTORIAL2
{
    internal class pra9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());

            int size = 2 * N + 2;
            int[] arr = new int[size];

            Console.WriteLine($"Enter {size} elements:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Step 1: Sort the array
            Array.Sort(arr);

            // Step 2: Traverse to find numbers without pairs
            int[] result = new int[2];
            int idx = 0;

            for (int i = 0; i < size - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    i++; // skip the pair
                }
                else
                {
                    result[idx++] = arr[i];
                }
            }

            // Last element may be unpaired
            if (idx < 2)
                result[idx++] = arr[size - 1];
            Console.Write("Output:");
            Array.Sort(result); // for neat output
            Console.WriteLine($"{result[0]} {result[1]}");
        }
    }
}
