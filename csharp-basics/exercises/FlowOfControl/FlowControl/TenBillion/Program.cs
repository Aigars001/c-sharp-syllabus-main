using System;

namespace TenBillion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            var input = Convert.ToInt32(Console.ReadLine());
            var inputStr = input.ToString();

            if (input < 0)
            {
                input = Math.Abs(input);
                inputStr = input.ToString();
            }

            if (inputStr.Length > 1)
            {
                int digits = 1;

                if (inputStr.Length == 2)
                {
                    digits = 2;
                }
                else if (inputStr.Length == 3)
                {
                    digits = 3;
                }
                else if (inputStr.Length == 4)
                {
                    digits = 4;
                }
                else if (inputStr.Length == 5)
                {
                    digits = 5;
                }
                else if (inputStr.Length == 6)
                {
                    digits = 6;
                }
                else if (inputStr.Length == 7)
                {
                    digits = 7;
                }
                else if (inputStr.Length == 8)
                {
                    digits = 8;
                }
                else if (inputStr.Length == 9)
                {
                    digits = 9;
                }
                else if (inputStr.Length == 10)
                {
                    digits = 10;
                }

                else if (inputStr.Length > 10)
                {
                    Console.WriteLine("Number is greater or equals 10,000,000,000!");
                }

                Console.WriteLine("Number of digits in the number: " + digits);
            }
            else
            {
                Console.WriteLine("The number is not long");
            }
            Console.ReadLine();
        }
    }
}
