/*Define EnrolmentNo and Name properties for the Student class and demonstrate use of these 
 properties along with required data members, methods and constructors.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA.TUTORIAL3
{
    internal class Students
    {
        private int enrolmentNo;
        private string name;
        public int EnrolmentNo
        {
            get { return enrolmentNo; }
            set { enrolmentNo = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Students(int enrolmentNo, string name)
        {
            this.enrolmentNo = enrolmentNo;
            this.name = name;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Enrolment No: " + enrolmentNo);
            Console.WriteLine("Name: " + name);
        }
    }
    class TestStudents
    {
        public static void Main(string[] args)
        {
            Students s1 = new Students(29, "Amrita");
            Students s2 = new Students(20, "Arpita");
            s1.DisplayInfo();
            s2.DisplayInfo();

            s1.EnrolmentNo = 25;
            s1.Name = "Amit";

            Console.WriteLine("\nAfter updating details:");
            s1.DisplayInfo();

            Console.ReadKey();
        }
    }
}
