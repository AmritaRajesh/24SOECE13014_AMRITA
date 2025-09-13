/*3 : Define a Student class with appropriate data members, property, constructors, methos etc. 
Define another class called TestStudent within the same .cs file. 
Also create an object of student class and demonstrate the use of student class.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA.TUTORIAL3
{
    internal class Student
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
            Student s1 = new Student(29, "Amrita", 21);
            s1.Display();

            Console.ReadKey();
        }
    }
}

