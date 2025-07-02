//Find out whether the given number is odd or even.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13014_AMRITA
{
    internal class pra3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number.");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number.");
            }
            Console.ReadLine();
        }
    }
}
