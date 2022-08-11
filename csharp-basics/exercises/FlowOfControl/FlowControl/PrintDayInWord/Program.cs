using System;

namespace PrintDayInWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number from 0 to 6!");

            var day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 0:
                    Console.WriteLine("Its Sunday!");
                    break;
                case 1:
                    Console.WriteLine("Its Monday!");
                    break;
                case 2:
                    Console.WriteLine("Its Tuesday!");
                    break;
                case 3:
                    Console.WriteLine("Its Wednesday!");
                    break;
                case 4:
                    Console.WriteLine("Its Thursday!");
                    break;
                case 5:
                    Console.WriteLine("Its Friday!");
                    break;
                case 6:
                    Console.WriteLine("Its Saturday!");
                    break;
                default:
                    Console.WriteLine("Not a valid day");
                    break;
            }

            Console.ReadKey();
        }
    }
}
