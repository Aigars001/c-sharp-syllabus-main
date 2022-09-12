// See https://aka.ms/new-console-template for more information
//ToDo: Write a query that returns names of days
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DaysNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var daysNames = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>();

            foreach (var d in daysNames)
            {
                Console.Write($"{d} ");
            }

            Console.ReadKey();
        }
    }
}