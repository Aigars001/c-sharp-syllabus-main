using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Is15())
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.ReadKey();
        }
        static bool Is15()
        {
            Console.WriteLine("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            return number1 == 15 || number2 == 15 ||
                   number1 + number2 == 15 ||
                   number1 - number2 == 15 ||
                   number2 - number1 == 15;
        }
    }
}