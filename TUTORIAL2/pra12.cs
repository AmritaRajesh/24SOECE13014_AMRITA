//12. Write a program to find the element from an Array and print 1 if element is found else print 0.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA.TUTORIAL2
{
    internal class pra12
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

            Console.Write("Enter element to search: ");
            int X = int.Parse(Console.ReadLine());

            int found = 0; // flag

            for (int i = 0; i < N; i++)
            {
                if (arr[i] == X)
                {
                    found = 1;
                    break;
                }
            }

            Console.WriteLine(found);
        }
    }
}
