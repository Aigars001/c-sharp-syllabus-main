using System;
using System.Linq;

namespace ReplaceSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" };

            var selectedWords = words.Select(w => w.Contains("ea") ? w.Replace("ea", "*") : w);

            foreach (var word in selectedWords)
            {
                Console.WriteLine(word); 
            }

            Console.ReadKey();
        }
    }
}
