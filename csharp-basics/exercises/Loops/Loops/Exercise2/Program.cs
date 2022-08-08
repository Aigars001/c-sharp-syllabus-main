using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Input number of terms : ");

             int n = Convert.ToInt32(Console.ReadLine());

             for (int i = 1; i <= n; i++) 
             {
                 Console.WriteLine(Pow(i,n));
             }

             Console.ReadKey();
        }

         static int Pow(int number, int times)
         {
             int result = 1;

             if (times > 0)
             {
                 for (int i = 0; i < times; ++i)
                 {
                     result *= number;
                 }
             }

             return result;
         }
    }
}
