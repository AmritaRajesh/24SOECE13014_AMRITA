using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA.Zero_to_coder
{
    internal class ToDoList
    {
        static void Main()
        {
            List<string> tasks = new List<string>();
            int choice;

            do
            {
                Console.WriteLine("\n--- TO-DO LIST ---");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Remove Task");
                Console.WriteLine("0. Exit");
                Console.Write("Choose: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter task: ");
                        tasks.Add(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("\nYour Tasks:");
                        for (int i = 0; i < tasks.Count; i++)
                            Console.WriteLine($"{i + 1}. {tasks[i]}");
                        break;
                    case 3:
                        Console.Write("Enter task number to remove: ");
                        int index = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (index >= 0 && index < tasks.Count)
                            tasks.RemoveAt(index);
                        break;
                }
            } while (choice != 0);
        }
    }
}
