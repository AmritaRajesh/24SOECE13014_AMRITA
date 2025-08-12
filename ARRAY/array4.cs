//4. Write a C# Sharp program to copy the elements of one array into another array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA.ARRAY
{
    internal class array4
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] sourceArray = new int[n];
            int[] destinationArray = new int[n];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                sourceArray[i] = int.Parse(Console.ReadLine());
            }

            // Copy elements
            for (int i = 0; i < n; i++)
            {
                destinationArray[i] = sourceArray[i];
            }

            Console.WriteLine("\nElements copied to the new array:");
            foreach (int item in destinationArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
