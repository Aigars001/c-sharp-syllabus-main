using System;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr1 = new string[] { "mavis", "senaida", "letty" };
            var arr2 = new string[] { "samuel", "MABELLE", "letitia", "meridith" };
            var arr3 = new string[] { "Slyvia", "Kristal", "Sharilyn", "Calista" };

            CapMe(arr1);
            CapMe(arr2);
            CapMe(arr3);
            Console.ReadKey();

            static void CapMe(string[] arrayOfWords)
            {
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
            }
        }
    }
}
