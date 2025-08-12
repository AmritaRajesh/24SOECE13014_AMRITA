//5 : Write output of the program. Also write comment for each line for the following code.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13014_AMRITA
{
    internal class pra5
    {
        static void Main(string[] args)
        {
            int n, fact = 1; // Declare variables for number and factorial
            Console.Write("Enter Number : "); // Prompt user for input
            string str = Console.ReadLine(); // Read input from console
            n = Convert.ToInt32(str); // Convert input string to integer
            for (int i = 1; i <= n; i++) // Loop from 1 to n
            {
                fact = fact * i; // Calculate factorial
            }
            Console.Write("Factorial : {0}", fact); // Output the factorial result
            Console.Read(); // Wait for user input before closing
        }
    }
}
