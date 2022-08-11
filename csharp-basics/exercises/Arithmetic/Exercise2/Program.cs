using System;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next();
            Console.WriteLine(num);

            if (num % 2 == 0)
            {
                Console.WriteLine("number is even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }

            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}