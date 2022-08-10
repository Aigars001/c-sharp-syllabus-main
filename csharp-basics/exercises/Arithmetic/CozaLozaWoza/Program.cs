using System;

namespace CozaLozaWoza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lineOfText = "";

            for (int i = 1; i <= 110; i++)
            {
                if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
                {
                    lineOfText += "CozaLozaWoza ";
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    lineOfText += "CozaLoza ";
                }
                else if (i % 5 == 0 && i % 7 == 0)
                {
                    lineOfText += "LozaWoza ";
                }
                else if (i % 3 == 0 && i % 7 == 0)
                {
                    lineOfText += "CozaWoza ";
                }
                else if (i % 3 == 0)
                {
                    lineOfText += "Coza ";
                }
                else if (i % 5 == 0)
                {
                    lineOfText += "Loza ";
                }
                else if (i % 7 == 0)
                {
                    lineOfText += "Woza ";
                }
                else
                {
                    lineOfText += i + " ";
                }

                if (i % 11 == 0)
                {
                    lineOfText += "\n";
                }
            }
            Console.WriteLine(lineOfText);
            Console.ReadKey();
        }
    }
}