using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            double average;
            int lowerBound = 1;
            int upperBound = 100;

            for (var number = lowerBound; number <= upperBound; number++)
            {
                sum += number;
            }
            average = sum / (double)upperBound;
            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("The average is: " + average);
            Console.ReadKey();
        }
    }
}
