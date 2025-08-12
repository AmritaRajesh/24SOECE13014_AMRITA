//9. Write a C# Sharp program to delete an element at the desired position from an array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA.ARRAY
{
    internal class array9
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the position to delete (1 to {0}): ", n);
            int pos = int.Parse(Console.ReadLine());

            if (pos < 1 || pos > n)
            {
                Console.WriteLine("Invalid position!");
            }
            else
            {
                // Shift elements to the left
                for (int i = pos - 1; i < n - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                n--; // Reduce array size

                Console.WriteLine("\nArray after deletion:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
