using System;

namespace PhoneKeyPad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text");
            string text = Console.ReadLine();

            text = text.ToLower();

            char[] textToChar = text.ToCharArray();

            foreach (char letter in textToChar)
            {
                letter.ToString().ToLower();
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (textToChar[i] == 'a' || textToChar[i] == 'b' || textToChar[i] == 'c')
                {
                    Console.Write(2);
                }
                else if (textToChar[i] == 'd' || textToChar[i] == 'e' || textToChar[i] == 'f')
                {
                    Console.Write(3);
                }
                else if (textToChar[i] == 'g' || textToChar[i] == 'h' || textToChar[i] == 'i')
                {
                    Console.Write(4);
                }
                else if (textToChar[i] == 'j' || textToChar[i] == 'k' || textToChar[i] == 'l')
                {
                    Console.Write(5);
                }
                else if (textToChar[i] == 'm' || textToChar[i] == 'n' || textToChar[i] == 'o')
                {
                    Console.Write(6);
                }
                else if (textToChar[i] == 'p' || textToChar[i] == 'q' || textToChar[i] == 'r' || textToChar[i] == 's')
                {
                    Console.Write(7);
                }
                else if (textToChar[i] == 't' || textToChar[i] == 'u' || textToChar[i] == 'v')
                {
                    Console.Write(8);
                }
                else if (textToChar[i] == 'w' || textToChar[i] == 'x' || textToChar[i] == 'y' || textToChar[i] == 'z')
                {
                    Console.Write(9);
                }
                else
                {
                    Console.Write(textToChar[i]);
                }
            }
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}