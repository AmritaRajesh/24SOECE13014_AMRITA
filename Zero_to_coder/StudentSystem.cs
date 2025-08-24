using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA.Zero_to_coder
{
    internal class StudentSystem
    {
        static void Main()
        {
            Dictionary<string, int> students = new Dictionary<string, int>();

            while (true)
            {
                Console.WriteLine("\n1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Exit");
                Console.Write("Choose: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter marks: ");
                    int marks = Convert.ToInt32(Console.ReadLine());
                    students[name] = marks;
                }
                else if (choice == 2)
                {
                    int total = 0;
                    Console.WriteLine("\n--- Student Records ---");
                    foreach (var s in students)
                    {
                        Console.WriteLine($"{s.Key} : {s.Value}");
                        total += s.Value;
                    }
                    if (students.Count > 0)
                        Console.WriteLine("Average = " + (total / students.Count));
                }
                else break;
            }
        }
    }
}
