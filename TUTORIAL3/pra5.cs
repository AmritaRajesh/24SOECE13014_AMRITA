using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA.TUTORIAL3
{
    internal class pra5
    {
        int pcode;
        String pname, mname;

        public pra5(int pcd, String pnm, String mnm)
        {
            pcode = pcd;
            pname = pnm;
            mname = mnm;
        }

        public void Display()
        {
            Console.WriteLine("\nProduct Code:= " + pcode);
            Console.WriteLine("\nProduct Name:= " + pname);
            Console.WriteLine("\nManufacturer Name:= " + mname);
        }
    }

    public class TestProduct
    {
        public static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Syntax Error\n");
                Console.WriteLine("Must Have THREE Arguments\n");
                Console.WriteLine("Please, Write as [csc TestProduct ProductCode ProductName Manufacturer] \n");
            }
            else
            {
                int pcd = Convert.ToInt32(args[0]);
                String pnm = args[1];
                String mnm = args[2];

                pra5 p = new pra5(pcd, pnm, mnm);
                p.Display();

                Console.Read();
            }
        }
    }
}
