using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA.TUTORIAL3
{
    internal class pra2
    {
        private int hour, min, sec;

        public pra2()
        {
            hour = 12; min = 0; sec = 0;
        }

        public pra2(int h, int m, int s)
        {
            hour = h; min = m; sec = s;
        }

        public void Tick()
        {
            sec++;
            if (sec == 60) { sec = 0; min++; }
            if (min == 60) { min = 0; hour++; }
            if (hour == 24) { hour = 0; }
        }

        public void Display()
        {
            Console.WriteLine($"{hour:D2}:{min:D2}:{sec:D2}");
        }

        public int getHour() => hour;
        public int getMinute() => min;
        public int getSeconds() => sec;
    }

    class TestClock
    {
        static void Main()
        {
            pra2 c1 = new pra2();
            pra2 c2 = new pra2(10, 59, 58);

            c1.Display();
            c2.Display();

            c2.Tick();
            c2.Display();

            Console.ReadKey();
        }
    }
}
