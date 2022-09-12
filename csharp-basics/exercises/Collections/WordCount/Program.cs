using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = File.ReadAllText("../../lear.txt");
            int lineCount = path.Split('\n').Length;

            int wordCount = 0;
            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == ' ' || path[i] == '\n' || path[i] == '\'')
                {
                    wordCount++;
                }
            }

            var charsCount = 0;
            string s = "";
            for (int i = 0; i < path.Length; i++)
            {
                s = Regex.Replace(path, @"\n", "");
                charsCount = s.Length;
            }
            
            Console.WriteLine(path);
            Console.WriteLine($"Lines: = {lineCount}");
            Console.WriteLine($"Words: = {wordCount}");
            Console.WriteLine($"Characters: = {charsCount}");
            Console.ReadKey();
        }
    }
}
