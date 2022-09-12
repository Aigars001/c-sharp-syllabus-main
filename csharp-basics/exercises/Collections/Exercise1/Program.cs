using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            List<string> list = array.ToList();
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            HashSet<string> set = array.ToHashSet();
            foreach (string j in set)
            {
                Console.WriteLine(j);
            }

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            string val = "";
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == "Audi" || array[i] == "BMW" || array[i] == "Mercedes" || array[i] == "VolksWagen") { val = "Germany"; }

                else if (array[i] == "Honda") { val = "Japan"; }

                else if (array[i] == "Tesla") { val = "USA"; }

                if (!dictionary.ContainsKey(array[i]))
                {
                    dictionary.Add(array[i], val);
                }
            }
            foreach (KeyValuePair<string, string> item in dictionary)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            Console.ReadLine();
        }
    }
}
