/* 14. Write a Program to find the eligibility of admission for a  professional course
based on the following criteria:
Marks in Maths >=65
Marks in Phy >=55
Marks in Chem>=50 and
Total in all three subject >=180 or
Total in Math and Physics >=140
INPUT:
Input the marks obtained in Maths :72
Input the marks obtained in Physics :65
Input the marks obtained in Chemistry :51
OUTPUT:
The candidate is eligible for admission. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA.TUTORIAL2
{
    internal class pra14
    {
        static void Main(string[] args)
        {
            Console.Write("Input the marks obtained in Maths : ");
            int maths = int.Parse(Console.ReadLine());

            Console.Write("Input the marks obtained in Physics : ");
            int physics = int.Parse(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry : ");
            int chemistry = int.Parse(Console.ReadLine());

            int totalAll = maths + physics + chemistry;
            int totalMathPhy = maths + physics;

            if (maths >= 65 && physics >= 55 && chemistry >= 50 &&
                (totalAll >= 180 || totalMathPhy >= 140))
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }
    }
}
