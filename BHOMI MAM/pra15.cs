//15  Write a Program to check whether the given no is Armstrong no or not.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA
{
    internal class pra15
    {
        public static void Main(string[] args)
        {
            int number = 0, len = 0, sum = 0, clone;
            Console.Write("Enter a number: ");
            clone = number = Convert.ToInt32(Console.ReadLine());
            len = number.ToString().Length;

            while (number > 0)
            {
                sum += Convert.ToInt32(Math.Pow((number % 10), len));
                number /= 10;
            }
            Console.WriteLine($"{clone} is{(clone == sum ? "" : " not")} armstrong ");
        }
    }
}
