using System;

namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();

            int uperrCaseCount = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (char.IsUpper(sentence[i])) uperrCaseCount++;
            }

            Console.WriteLine(uperrCaseCount);
        }
    }
}