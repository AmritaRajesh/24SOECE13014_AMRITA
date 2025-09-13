/*4 : Use above program classes and create objects for 5 students and demonstrate the use student class.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA.TUTORIAL3
{
    class Student
    {
        private int enrolmentNo;
        private string name;
        private int age;

        public Student(int e, string n, int a)
        {
            enrolmentNo = e;
            name = n;
            age = a;
        }

        public void Display()
        {
            Console.WriteLine($"EnrolmentNo: {enrolmentNo}, Name: {name}, Age: {age}");
        }
    }

    class TestStudent
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student(101, "Amrita", 20);
            Student s2 = new Student(102, "Arpita", 15);
            Student s3 = new Student(103, "Amit", 22);
            Student s4 = new Student(104, "Komal", 20);
            Student s5 = new Student(105, "Krishna", 23);

            s1.Display();
            s2.Display();
            s3.Display();
            s4.Display();
            s5.Display();

            Console.ReadKey();
        }
    }
}
