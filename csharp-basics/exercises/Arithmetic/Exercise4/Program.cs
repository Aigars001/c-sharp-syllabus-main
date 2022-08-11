using System;

namespace Product1ToN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = Enumerable.Range(1, 10).ToArray();

            int result = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                result *= array[i];
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
