using System;

namespace Exercise2
{
    class Program
    {
        private static void Main(string[] args)
        {
            var sum = 0;

            Console.WriteLine("Please enter a min number");
            int minNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int maxNumber = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[maxNumber+1 - minNumber];

            int index = 0;

            for (int i = minNumber; i <= maxNumber; i++)
            {
                 myArray[index++] = i;
            }

            foreach (int num in myArray)
            {
                sum += num;
            }

            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
        }
    }
}
