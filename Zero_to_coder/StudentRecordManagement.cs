using System;
using System.Collections.Generic;

class Student
{
    public int RollNo { get; set; }
    public string Name { get; set; }
    public double Marks { get; set; }
}

class StudentRecordManagement
{
    static List<Student> students = new List<Student>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== Student Record Management =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Search Student by Roll No");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    ViewStudents();
                    break;
                case "3":
                    SearchStudent();
                    break;
                case "4":
                    Console.WriteLine("Exiting... Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void AddStudent()
    {
        Console.Write("Enter Roll No: ");
        int roll = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Marks: ");
        double marks = double.Parse(Console.ReadLine());

        students.Add(new Student { RollNo = roll, Name = name, Marks = marks });

        Console.WriteLine("✅ Student added successfully!");
    }

    static void ViewStudents()
    {
        Console.WriteLine("\n--- Student List ---");
        if (students.Count == 0)
        {
            Console.WriteLine("No records found.");
            return;
        }

        foreach (var s in students)
        {
            Console.WriteLine($"Roll No: {s.RollNo}, Name: {s.Name}, Marks: {s.Marks}");
        }
    }

    static void SearchStudent()
    {
        Console.Write("Enter Roll No to search: ");
        int roll = int.Parse(Console.ReadLine());

        var student = students.Find(s => s.RollNo == roll);

        if (student != null)
        {
            Console.WriteLine($"Found: Roll No: {student.RollNo}, Name: {student.Name}, Marks: {student.Marks}");
        }
        else
        {
            Console.WriteLine("Student not found!");
        }
    }
}
