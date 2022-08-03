using System;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];

            var rnd = new Random();

            for (int i = 0; i < array1.Length; i++)
            { 
                int number = rnd.Next(0, 101);
                array1[i] = number;
            }

            Array.Copy(array1, array2, array1.Length);

            array1[array1.Length - 1] = -7;

            Console.Write("Array 1: ");

            foreach (var num in array1)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.Write("Array 2: ");

            foreach (var num in array2)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}