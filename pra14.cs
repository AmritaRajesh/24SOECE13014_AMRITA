//14 Write a Program which accepts no from the user and print the same in words.
//INPUT : 98732
//OUTPUT: Nine Eight Seven Three Two

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA
{
    internal class pra14
    {
        public static void Main(string[] args)
        { 
            Console.Write("Enter a number:");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || !input.All(char.IsDigit))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }
            string[] words = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '0': words[i] = "Zero"; break;
                    case '1': words[i] = "One"; break;
                    case '2': words[i] = "Two"; break;
                    case '3': words[i] = "Three"; break;
                    case '4': words[i] = "Four"; break;
                    case '5': words[i] = "Five"; break;
                    case '6': words[i] = "Six"; break;
                    case '7': words[i] = "Seven"; break;
                    case '8': words[i] = "Eight"; break;
                    case '9': words[i] = "Nine"; break;
                    default: words[i] = ""; break; // This should not happen due to earlier validation
                }
            }
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
