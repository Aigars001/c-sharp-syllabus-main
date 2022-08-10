using System;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter minutes");
            int minutes = Convert.ToInt32(Console.ReadLine());

            int year = minutes / 525600;
            int day = minutes / 1440;

            Console.WriteLine("it is: " + year + "years");
            Console.WriteLine("it is: " + day + "days");
        }
    }
}