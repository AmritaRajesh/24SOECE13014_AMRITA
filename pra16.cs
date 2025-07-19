//16  Write a program to display a pattern like a right angle triangle using an asterisk

//The pattern like :

//*

//**

//***

//****

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA
{
    internal class pra16
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    System.Console.Write('*');
                }
                System.Console.WriteLine();
            }
        }

    }
}
