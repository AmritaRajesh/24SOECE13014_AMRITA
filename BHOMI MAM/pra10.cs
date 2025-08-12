//Write a Program which accepts mobile no as a string from the user and converts the last 5 digits into X.
//INPUT : 1234567890
//OUTPUT: 12345XXXXX

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA
{
    internal class pra10
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your mobile number: ");
            string str = Console.ReadLine();
            string[] myArray = new string[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                myArray[i] = str[i].ToString();
                if (i >= 5)
                {
                    myArray[i] = "X";
                }
            }
            Console.WriteLine(string.Join("", myArray));
        }
    }
}
