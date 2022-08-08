using System;

namespace GetTheCentury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Century());
            Console.ReadKey();
        }

        private static string Century()
        {
            Console.WriteLine("Enter a year from 1000 to 2100");
            int year = Convert.ToInt32(Console.ReadLine());

            var centuryFromYear = "";

            if (year >= 1001 && year < 1101)
            {
                centuryFromYear = "11th Century";
            }
            else if (year >= 1101 && year < 1201)
            {
                centuryFromYear = "12th Century";
            }
            else if (year >= 1201 && year < 1201)
            {
                centuryFromYear = "13th Century";
            }
            else if (year >= 1301 && year < 1401)
            {
                centuryFromYear = "14th Century";
            }
            else if (year >= 1401 && year < 1501)
            {
                centuryFromYear = "15th Century";
            }
            else if (year >= 1501 && year < 1601)
            {
                centuryFromYear = "16th Century";
            }
            else if (year >= 1601 && year < 1701)
            {
                centuryFromYear = "17th Century";
            }
            else if (year >= 1701 && year < 1801)
            {
                centuryFromYear = "18th Century";
            }
            else if (year >= 1801 && year < 1901)
            {
                centuryFromYear = "19th Century";
            }
            else if (year >= 1901 && year < 2001)
            {
                centuryFromYear = "20th Century";
            }
            else if (year >= 2001 && year < 2101)
            {
                centuryFromYear = "21st Century";
            }
            else
            {
                centuryFromYear = "Error";
            }
            return centuryFromYear;

        }
    }
}
