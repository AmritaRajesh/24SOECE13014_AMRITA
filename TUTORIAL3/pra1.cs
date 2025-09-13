using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA.TUTORIAL3
{
    internal class pra1
    {
        private string brand;
        private string model;
        private int price;

        public pra1(string b, string m, int p)
        {
            brand = b;
            model = m;
            price = p;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Price: " + price);
        }

        public void IncreasePrice(int amount)
        {
            price += amount;
            Console.WriteLine("Price increased by " + amount);
        }
    }

    class Demo
    {
        public static void Main(string[] args)
        {
            pra1 car1 = new pra1("BMW", "X5", 7500000);
            pra1 car2 = new pra1("Tesla", "Model S", 8500000);

            Console.WriteLine("\nCar 1 Info:");
            car1.DisplayInfo();
            car1.IncreasePrice(50000);
            car1.DisplayInfo();

            Console.WriteLine("\nCar 2 Info:");
            car2.DisplayInfo();
            car2.IncreasePrice(100000);
            car2.DisplayInfo();

            Console.ReadKey();
        }
    }
}

