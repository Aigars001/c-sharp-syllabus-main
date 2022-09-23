using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();

            list.Add("Brown");
            list.Add("Blue");
            list.Add("Green");
            list.Add("Yellow");
            list.Add("White");
            list.Add("Purple");
            list.Add("Silver");
            list.Add("Gold");
            list.Add("Pink");
            list.Add("Brown");

            list.Insert(4, "Something");
            Console.WriteLine("5th element changed: " + String.Join(",", list));

            list[list.Count - 1] = "Changed";
            Console.WriteLine("\nlast element changed: " + String.Join(",", list));

            list.Sort();
            Console.WriteLine("\nSorted list: " + String.Join(",", list));
            Console.WriteLine();

            Console.WriteLine(list.Contains("Foobar") ? "Contains" : "Doesnt contain");
            Console.WriteLine();

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }
    }
}
