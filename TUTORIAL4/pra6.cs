//6 :  Find out error code and correct it. Print appropriate output as desired.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13014_AMRITA.TUTORIAL4
{
    abstract class Test
    {
        protected int a;              
        public abstract void A();     
    }

    class Example1 : Test
    {
        public override void A()
        {
            a++;
            Console.WriteLine("Example1.A, a = " + a);
        }
    }

    class Example2 : Test
    {
        public override void A()
        {
            a--;
            Console.WriteLine("Example2.A, a = " + a);
        }
    }

    class Program
    {
        static void Main()
        {
            Test test1 = new Example1();
            test1.A();   

            Test test2 = new Example2();
            test2.A();   
        }
    }
}
