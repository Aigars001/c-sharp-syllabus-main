using System;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 single digit numbers");

            int numbers = 0;

            for (int i = 0; i < 3; i++)
            {
                numbers += Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("result is: " + numbers);
        }
    }
}