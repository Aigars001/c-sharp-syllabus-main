using System;
using System.ComponentModel.Design;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            int guess = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int number = rnd.Next(1, 100);

            if (guess > 100 || guess < 1)
            {
                Console.WriteLine("Out of range");
            }
            else if (guess > number)
            {
                Console.WriteLine("Sorry, you are too high. I was thinking of " + number + ".");
            }
            else if (guess < number)
            {
                Console.WriteLine("Sorry, you are too low. I was thinking of " + number + ".");
            }
            else if (guess == number)
            {
                Console.WriteLine("You guessed it! What are the odds?!?");
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadKey();
        }
    }
}