/* 13. Write a Program that will accept the amount and find how many minimum
no of notes you required for that.
(Using the rupee notes of 1, 2, 5, 10, 20, 50, 100, 200, 500, 2000)
Input: 5748
Output:
Notes of Rs.2000 = 2 Notes of Rs.500 = 3 Notes of Rs.200 = 1
Notes of Rs.20 = 2 Notes of Rs.10 = 0 Notes of Rs.5 = 1
Notes of Rs.2 = 1 Notes of Rs.1 = 1 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA.TUTORIAL2
{
    internal class pra13
    {
        static void Main(string[] args)
        {
            // Denominations available in Indian currency
            int[] notes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            Console.Write("Enter the amount: ");
            int amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Minimum number of notes required:");

            foreach (int note in notes)
            {
                int count = amount / note;
                if (count > 0)
                {
                    Console.WriteLine($"Notes of Rs.{note} = {count}");
                    amount %= note;
                }
            }
        }

    }
}
