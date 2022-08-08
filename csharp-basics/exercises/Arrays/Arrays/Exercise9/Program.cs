using System;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some words separated with spaces!");
            var userInput = Console.ReadLine();
            string[] arrayOfWords = userInput.Trim().Split(" ");

            var arrayOfWordsLowerCase = arrayOfWords.Select(s => s.ToLowerInvariant()).ToArray();
            var firstCharUpper = "";
            var firstCharUpperArray = new string[arrayOfWordsLowerCase.Length];

            foreach (var word in arrayOfWordsLowerCase)
            {
                char[] charArray = word.ToCharArray();
                charArray[0] = char.ToUpper(charArray[0]);
                firstCharUpper += new string(charArray) + " ";
            }
            
            firstCharUpperArray = firstCharUpper.Split(" ");

            Console.WriteLine(String.Join(" ", firstCharUpperArray));
            Console.ReadKey();
        }
    }
}
