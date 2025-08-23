/*15.Write a Program which accepts name from the user and prints the same

INPUT : R K University
OUTPUT: R K University   */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA.TUTORIAL2
{
    internal class pra15
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("You entered: " + name);
        }
    }
}
