//9 : This program will throw an exception. Add try, catch and finally blocks to handle this       exception.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13014_AMRITA.TUTORIAL4
{
    using System;

    class MyClient
    {
        public static void Main()
        {
            int x = 0;
            int div = 0;

            try
            {
                div = 100 / x;
                Console.WriteLine("Division Result: " + div);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception Message: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution completed (finally block).");
            }
        }
    }
}
