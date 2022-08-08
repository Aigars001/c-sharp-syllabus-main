using System;

namespace CozaLozaWoza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lineOftext = "";
            int countOfNumbers = 0;

            for (int i = 1; i <= 110; i++)
            {
                if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                {
                    lineOftext += "CozaLozaWoza ";
                    countOfNumbers++;
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    lineOftext += "CozaLoza ";
                    countOfNumbers++;
                }
                else if (i % 5 == 0 && i % 7 == 0)
                {
                    lineOftext += "LozaWoza ";
                    countOfNumbers++;
                }
                else if (i % 3 == 0 && i % 7 == 0)
                {
                    lineOftext += "CozaWoza ";
                    countOfNumbers++;
                }
                else if (i % 3 == 0)
                {
                    lineOftext += "Coza ";
                    countOfNumbers++;
                }
                else if (i % 5 == 0)
                {
                    lineOftext += "Loza ";
                    countOfNumbers++;
                }
                else if (i % 7 == 0)
                {
                    lineOftext += "Woza ";
                    countOfNumbers++;
                }
                else
                {
                    lineOftext += i + " ";
                    countOfNumbers++;
                }

                if (countOfNumbers % 11 == 0)
                {
                    lineOftext += "\n";
                }
            }
            Console.WriteLine(lineOftext);
            Console.ReadKey();
        }
    }
}