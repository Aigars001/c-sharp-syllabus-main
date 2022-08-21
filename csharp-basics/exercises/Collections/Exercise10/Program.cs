using System;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myset = new HashSet<string>();

            myset.Add("aaaa");
            myset.Add("bbbb");
            myset.Add("cccc");
            myset.Add("dddd");
            myset.Add("eeee");

            foreach (var str in myset)
            {
                Console.WriteLine(str);
            }

            myset.Clear();

            Console.WriteLine(CheckForDuplicate(myset));
            Console.ReadKey();
        }

        public static bool CheckForDuplicate(HashSet<string> set)
        {
            return set.Count != set.Distinct().Count();
        }
    }
}