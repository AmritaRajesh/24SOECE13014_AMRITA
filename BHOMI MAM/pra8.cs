//Write a program to convert given name in upper characters.
//INPUT : John F Kennedy
//OUTPUT: JOHN F KENNEDY

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA
{
    internal class pra8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            string upperName = name.ToUpper();
            Console.WriteLine($"Uppercase Name: {upperName}");
            Console.ReadLine();
        }
    }
}
