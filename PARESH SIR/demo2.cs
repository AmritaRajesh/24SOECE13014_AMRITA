//333
//313
//323
//333

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA
{
    internal class demo2
    {
        public static void Main(string[] args)
        { 
             for (int i = 1; i <= 5; i++)
             {
                 for (int j = 1; j <= 3; j++)
                 {
                     if (i == 2 && j == 2)
                        Console.Write("1");
                     else if (i == 3 && j == 2)
                        Console.Write("2");
                    else if (i == 4 && j == 3)
                        Console.Write("3");
                    else
                        Console.Write("4");
                 }
                 Console.WriteLine();
             }
        }
    }
}