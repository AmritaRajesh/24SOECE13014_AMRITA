using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA.CIE_1
{
    internal class Employee
    {
        int empCode;
        string name;
        string designation;
        double basicPay, hra, da, totalPay;

        // Constructor
        public Employee(int code, string name, string desig, double basic)
        {
            this.empCode = code;
            this.name = name;
            this.designation = desig;
            this.basicPay = basic;
        }

        // Method to calculate salary
        public void CalculatePay()
        {
            hra = 0.10 * basicPay;
            da = 0.45 * basicPay;
            totalPay = basicPay + hra + da;

            Console.WriteLine("\nEmployee Code: " + empCode);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Designation: " + designation);
            Console.WriteLine("Basic Pay: " + basicPay);
            Console.WriteLine("HRA: " + hra);
            Console.WriteLine("DA: " + da);
            Console.WriteLine("Total Pay: " + totalPay);
        }
    }

    class EmployeeDemo
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(101, "Amrita", "Manager", 30000);
            Employee e2 = new Employee(102, "Komal", "Engineer", 25000);
            Employee e3 = new Employee(103, "Hema", "Clerk", 15000);

            e1.CalculatePay();
            e2.CalculatePay();
            e3.CalculatePay();
        }
    }
}
