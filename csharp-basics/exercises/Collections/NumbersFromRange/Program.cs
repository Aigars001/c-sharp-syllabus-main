using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersFromRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var random = new Random();
            var numbers = new List<int>();
            while (numbers.Count() < 10)
            {
                numbers.Add(random.Next(1, 100));
            }

            var selectedNumbers = numbers.Where(x => x > 30).Where(x => x < 100);

            foreach (var s in selectedNumbers)
            {
                Console.Write($"{s} ");
            }

            Console.ReadKey();
        }
    }
}
