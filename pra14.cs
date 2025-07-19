//14.Write a Program which accepts no from the user and print the same in words.
//INPUT: 98732
//OUTPUT: Nine Eight Seven Three Two


using System;
using System.Collections.Generic;

namespace _24SOECE213014_AMRITA
{
    internal class pra14
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            Dictionary<char, string> digitWords = new Dictionary<char, string>()
            {
                { '0', "Zero" },
                { '1', "One" },
                { '2', "Two" },
                { '3', "Three" },
                { '4', "Four" },
                { '5', "Five" },
                { '6', "Six" },
                { '7', "Seven" },
                { '8', "Eight" },
                { '9', "Nine" }
            };

            if (!long.TryParse(input, out _))
            {
                Console.WriteLine("Invalid input! Please enter digits only.");
                return;
            }

            foreach (char digit in input)
            {
                Console.Write(digitWords[digit] + " ");
            }

            Console.WriteLine();
        }
    }
}
