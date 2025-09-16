using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA.CIE_1
{
    internal class Array
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 10, 15, 20, 25 };

            Console.Write("Enter element to search: ");
            int key = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            foreach (int item in arr)
            {
                if (item == key)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine("1");
            else
                Console.WriteLine("0");
        }
    }
}
