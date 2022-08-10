using System;

namespace Piglet
{
    internal class Program
    {
        private static readonly Random Rnd = new Random();
        private static int _score;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!");
            Console.WriteLine("Do you want to start the game? y/n");
            char userInput = Console.ReadKey().KeyChar;

            if (userInput == 'n')
            {
                Console.Clear();
                Console.WriteLine("Bye");
            }
            else if (userInput == 'y')
            {
                Play(userInput);
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadKey();
        }

        private static void Play(char userInput)
        {
            while (true)
            {
                if (userInput == 'y')
                {
                    Console.Clear();
                    var randomNumber = Rnd.Next(1, 6);

                    if (randomNumber == 1)
                    {
                        _score = 0;
                        Console.Clear();
                        Console.WriteLine("You rolled a 1! You got 0 points. The game is over");
                        Exit(userInput);
                    }
                    else if (randomNumber > 1)
                    { 
                        _score += randomNumber;
                        Console.WriteLine($"You rolled a {randomNumber}!");
                        Console.WriteLine($"Current score: {_score}");
                        Console.WriteLine("Do you want to roll again? y/n");
                        userInput = Console.ReadKey().KeyChar;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                else if(userInput == 'n')
                {     
                    Console.Clear();
                    Console.WriteLine($"Your score is {_score}. The game is over.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else
                { 
                    Console.WriteLine("Unknown command try again");
                    userInput = Console.ReadKey().KeyChar;
                }
            }
        }

        private static void Exit(char userInput)
        {
            Console.WriteLine("Do you want to continue y/n? ");
            userInput = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (userInput == 'n')
            {
                Console.Clear();
                Console.WriteLine("Bye");
                Environment.Exit(0);
            }
            else
            {
                Play(userInput);
            }
        }
    }
}