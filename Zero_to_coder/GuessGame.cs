using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA.Zero_to_coder
{
    internal class GuessGame
    {
        static void Main()
        {
            Random rnd = new Random();
            int secret = rnd.Next(1, 101);
            int guess, attempts = 0;

            Console.WriteLine("Guess the number between 1 and 100!");

            do
            {
                Console.Write("Enter guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (guess > secret) Console.WriteLine("Too high!");
                else if (guess < secret) Console.WriteLine("Too low!");
            } while (guess != secret);

            Console.WriteLine($"🎉 Correct! You guessed it in {attempts} attempts.");
        }
    }
}
