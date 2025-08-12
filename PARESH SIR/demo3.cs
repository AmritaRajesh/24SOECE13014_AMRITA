// write a program to swap two variables by reference

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA
{
    internal class demo3
    {
        static void Swap(ref int a, ref int b)
        {
            a = 100;
            b = 200;
        }


        
        static void Update(out int x, out float y)
        {
            x = 100;
            y = 200.0f;
        }

        static void Main(string[] args)
        {
            int a = 10, b = 20;
            int x; float y;
            

            Console.WriteLine($"Before Swap: a = {0}, b = {1}", a, b);
            Swap(ref a, ref b);
            Console.WriteLine($"After Swap: a = {0}, b = {1}", a, b);
            Console.WriteLine($"Before Update: x = {0}, y = {1}", x, y);
            Update(out x, out y);
            Console.WriteLine($"After Update: x = {0}, y = {1}", x, y);
        }
    }
}
