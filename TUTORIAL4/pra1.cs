/*1 : The employee list for a company contains employee code, name, designation and basic pay. 
 * The employee is given a house rent allowance (HRA) of 10% of the basic pay and dearness allowance (DA) of 45% of the basic pay. 
 * The total pay of the employee is calculated as Basic Pay + HRA + DA. Write a class to define the details of the employee. 
 * Write a constructor to assign the required initial values. Add a method to calculate HRA, DA and total pay and print them. 
 * Write another class with main method. 
 * Create objects for three different employees and calculate HRA, DA and total pay.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13014_AMRITA.TUTORIAL4
{
    class Employee
    {
        private int empCode;
        private string empName;
        private string designation;
        private double basicPay;

        public Employee(int code, string name, string desig, double basic)
        {
            empCode = code;
            empName = name;
            designation = desig;
            basicPay = basic;
        }

        public void CalculateSalary()
        {
            double hra = 0.10 * basicPay;   
            double da = 0.45 * basicPay;    
            double totalPay = basicPay + hra + da;

            Console.WriteLine("\n--- Employee Salary Details ---");
            Console.WriteLine("Employee Code   : " + empCode);
            Console.WriteLine("Employee Name   : " + empName);
            Console.WriteLine("Designation     : " + designation);
            Console.WriteLine("Basic Pay       : " + basicPay);
            Console.WriteLine("HRA (10%)       : " + hra);
            Console.WriteLine("DA (45%)        : " + da);
            Console.WriteLine("Total Pay       : " + totalPay);
        }
    }
    internal class pra1
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(101, "Amrita", "Co Founder", 80000);
            Employee e2 = new Employee(102, "Arpita", "Manager", 50000);
            Employee e3 = new Employee(103, "Sneha", "HR Executive", 25000);

            e1.CalculateSalary();
            e2.CalculateSalary();
            e3.CalculateSalary();

            Console.ReadLine();
        }
    }
}
