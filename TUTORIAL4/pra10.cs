//10: Arrange the code to get desirable output

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13014_AMRITA.TUTORIAL4
{
    class MyException : Exception
    {
        public MyException(string str) : base(str)
        {

        }
    }

    class MyClient
    {
        public static void Main()
        {
            try
            {
                throw new MyException("my exception generated.");
            }
            catch (MyException e)
            {
                Console.WriteLine("Exception caught here: " + e.Message);
            }
            finally
            {
                Console.WriteLine("LAST STATEMENT");
            }
        }
    }
}
