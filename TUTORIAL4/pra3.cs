/*3:  Draw a real picture for single level inheritance.
Perform following tasks.
Task 1: Create a class
Task 2: Add few data members as private, protected and public
Task 3: Add few methods as public to work on defined data members
Task 4: Create another applicable class which inherits members from above class
Task 5: Add few data members as private, protected and public into second class
Task 6: Add few methods as public to work on defined data members into second class
Task 7: Create a Demo class with main method.
Task 8: Create at least two objects of a second class defined in Task 4 into main method and call all methods using that object.
Task 9: Write comment for each important portion of code like data members’ declaration, methods, some important logic etc.
Task 10: Summarize above solution in your own few words to visualize the solution to the end user. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13014_AMRITA.TUTORIAL4
{
    // Base Class (Parent) 
    class Employee
    {
        //  Data Members 
        private int empId;          
        protected string empName;   
        public double basicSalary;  

        // Constructor to initialize Employee 
        public Employee(int id, string name, double salary)
        {
            empId = id;
            empName = name;
            basicSalary = salary;
        }

        // Public method to display employee details 
        public void ShowEmployeeDetails()
        {
            Console.WriteLine("Employee ID   : " + empId);
            Console.WriteLine("Employee Name : " + empName);
            Console.WriteLine("Basic Salary  : " + basicSalary);
        }

        // Public method to increase salary 
        public void IncreaseSalary(double percent)
        {
            basicSalary += (basicSalary * percent / 100);
            Console.WriteLine(empName + " got a salary hike of " + percent + "%.");
        }
    }

    //  Derived Class (Child) 
    class Manager : Employee
    {
        //  Data Members 
        private string department;
        protected int teamSize;         
        public double bonus;            

        //  Constructor (calls base constructor using : base) 
        public Manager(int id, string name, double salary, string dept, int size, double bonusAmt)
            : base(id, name, salary)  
        {
            department = dept;
            teamSize = size;
            bonus = bonusAmt;
        }

        //  Public method to show Manager-specific details 
        public void ShowManagerDetails()
        {
            Console.WriteLine("Department    : " + department);
            Console.WriteLine("Team Size     : " + teamSize);
            Console.WriteLine("Bonus         : " + bonus);
        }

        //  Public method to calculate total salary (basic + bonus) 
        public void ShowTotalSalary()
        {
            double total = basicSalary + bonus;
            Console.WriteLine("Total Salary (Basic + Bonus) : " + total);
        }
    }
    internal class pra3
    {
        static void Main()
        {
            // Creating first Manager object 
            Manager m1 = new Manager(101, "Amrita", 60000, "IT", 10, 7000);

            Console.WriteLine("---- Manager 1 Details ----");
            m1.ShowEmployeeDetails();
            m1.ShowManagerDetails();
            m1.ShowTotalSalary();
            m1.IncreaseSalary(10);
            m1.ShowTotalSalary();
            Console.WriteLine();

            //  Creating second Manager object 
            Manager m2 = new Manager(102, "Arpita", 55000, "HR", 5, 9000);

            Console.WriteLine("---- Manager 2 Details ----");
            m2.ShowEmployeeDetails();
            m2.ShowManagerDetails();
            m2.ShowTotalSalary();
            m2.IncreaseSalary(5);
            m2.ShowTotalSalary();

            Console.ReadLine();
        }
    }
}
