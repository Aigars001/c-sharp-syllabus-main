using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            var input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            var input3 = Convert.ToInt32(Console.ReadLine());

            int[] num = { input1, input2, input3 };

            var temp = input1;

            for (int i = 0; i < num.Length; i++)
            {
                temp = Math.Max(num[i], temp);

            }
            Console.WriteLine("Largest: " + temp);

            Console.ReadKey();
        }
    }
}
