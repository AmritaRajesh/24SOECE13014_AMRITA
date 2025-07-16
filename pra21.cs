//21.Write a program to find the sum of the series 5 +55 + 555 + 5555 + .. n terms. 
//Test Data :
//Input the number of terms : 4

//Input number : 5
//Expected Output :
//5 + 55 + 555 + 5555
//The Sum is : 6170


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA
{
    internal class pra21
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the number of terms: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Input number: ");
            int num = int.Parse(Console.ReadLine());

            int term = 0;
            int sum = 0;

            Console.WriteLine();
            Console.Write("Series: ");

            for (int i = 1; i <= n; i++)
            {
                term = term * 10 + num;
                sum += term;

                Console.Write(term);
                if (i < n)
                    Console.Write(" + ");
            }

            Console.WriteLine();
            Console.WriteLine($"The Sum is : {sum}");
        }
    }
}
