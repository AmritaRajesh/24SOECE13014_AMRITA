//7. Write a program in C# Sharp to separate odd and even integers into separate arrays.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA.ARRAY
{
    internal class array7
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int[] evenArr = new int[n];
            int[] oddArr = new int[n];

            int evenCount = 0, oddCount = 0;

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Separate into even and odd arrays
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenArr[evenCount] = arr[i];
                    evenCount++;
                }
                else
                {
                    oddArr[oddCount] = arr[i];
                    oddCount++;
                }
            }

            Console.WriteLine("\nEven elements:");
            for (int i = 0; i < evenCount; i++)
            {
                Console.Write(evenArr[i] + " ");
            }

            Console.WriteLine("\nOdd elements:");
            for (int i = 0; i < oddCount; i++)
            {
                Console.Write(oddArr[i] + " ");
            }
        }
    }
}
