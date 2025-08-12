//12 Write a Program which accepts name from the user and prints the same
//INPUT : Winston Churchill
//OUTPUT: Winston Churchill

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA
{
    internal class pra12
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
    }
}
