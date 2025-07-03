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
            string mobileNumber = Console.ReadLine();
            if (mobileNumber.Length >= 5)
            {
                string maskedNumber = MaskLastFiveDigits(mobileNumber);
                Console.WriteLine($"Masked Mobile Number: {maskedNumber}");
            }
            else
            {
                Console.WriteLine("Mobile number must be at least 5 digits long.");
            }
            Console.ReadLine();
        }
        static string MaskLastFiveDigits(string number)
        {
            return number.Substring(0, number.Length - 5) + "XXXXX";
        }
    }
}
