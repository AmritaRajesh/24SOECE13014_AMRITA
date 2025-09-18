//4 : From the following code and given output complete missing statements and find out error code and correct it.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13014_AMRITA.TUTORIAL4
{
    class StaticVar
    {
        public static int num;   

        public StaticVar()
        {
            num++;
        }

        public void count()
        {
            new StaticVar(); 
        }

        public static int getNum()
        {
            return num;
        }
    }

    class StaticTester
    {
        static void Main(string[] args)
        {
            StaticVar s = new StaticVar(); 

            s.count();   
            s.count();   
            s.count();   

            Console.WriteLine("Variable num: {0}", StaticVar.getNum());
            Console.ReadKey();
        }
    }
}
