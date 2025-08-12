//*
//**
//***
//****
//*****
//****
//***
//**
//*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA
{
    internal class demo1
    {
        public static void Main(string[] args)

        {
            //int a = 2;
            //switch (a)
            //{
            //    case 1:
            //        Console.WriteLine("a = 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("a = 2");
            //        break;
            //    case 3:
            //        Console.WriteLine("a = 3");
            //        break;
            //    default:
            //        Console.WriteLine("a is not 1,2, or 3");
            //        break;
            //}
            //int rows = 5;

            // Upper part of the pattern
            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //// Lower part of the pattern
            //for (int i = rows - 1; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            for (int i = 1; i <= 9; i++)
            {
                int k;
                if (i <= 5)
                    k = i;
                else
                    k = 10 - i;

                for (int j = 1; j <= k; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
