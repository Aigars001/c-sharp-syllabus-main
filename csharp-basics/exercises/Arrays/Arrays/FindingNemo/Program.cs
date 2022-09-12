using System;

namespace FindingNemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Sentence1 = "I am finding Nemo !";
            string Sentence2 = "Nemo is me Nemo";

            Console.WriteLine($"Found Nemo at: {Nemo(Sentence1)}!");
            Console.WriteLine($"Found Nemo at: {Nemo(Sentence2)}!");
            Console.ReadKey();
        }

        static int Nemo(string stringForSearching)
        {
            int index = 0;
            var words = stringForSearching.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "Nemo")
                {
                    index = i+1;
                    break;
                }
            }
            return index;
        }
    }
}