//11  Write a Program which accepts name and gender from the user. Here, gender may have only 1 character, M or F.
//Based on the gender prefix the name Mr. & Ms.
//NAME : Hillary Clinton
//GENDER : F


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA
{
    internal class pra11
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Name: {name}");

            if (!(name.StartsWith("mr") || name.StartsWith("ms")))
                Console.WriteLine("Gender: Not mention");
            else if (name.StartsWith("mr"))
                Console.WriteLine("Gender: Male");
            else
                Console.WriteLine("Gender: Female");
        }
    }
}
