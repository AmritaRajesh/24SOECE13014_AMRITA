//11: Write a program to find the sum of N elements of an Array.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA.TUTORIAL2
{
    internal class pra11
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements (N): ");
            int N = int.Parse(Console.ReadLine());

            int[] arr = new int[N];
            Console.WriteLine("Enter the elements:");

            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine($"Sum of array elements = {sum}");
        }
    }
}
