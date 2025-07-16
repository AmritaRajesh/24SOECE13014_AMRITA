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
        public static void Main(string[]args) 
        {
            Console.Write("Enter a number:");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || !input.All(char.IsDigit))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }
            int number = int.Parse(input);
            int originalNumber = number;
            int sum = 0;
            int digitsCount = input.Length;
            while (number > 0)
            {
                int digit = number % 10;
                sum += (int)Math.Pow(digit, digitsCount);
                number /= 10;
            }
            if (sum == originalNumber)
            {
                Console.WriteLine($"{originalNumber} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{originalNumber} is not an Armstrong number.");
            }
        }
    }
}
