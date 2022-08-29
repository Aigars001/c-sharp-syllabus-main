using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("1. Logitech mouse", 70.00, 14);
            Product p2 = new Product("2. iPhone 5s", 999.99, 3 );
            Product p3 = new Product("3. Epson EB-U05", 440.46, 1);
           
            Console.WriteLine("Original \n");
            p1.PrintProduct();
            p2.PrintProduct();
            p3.PrintProduct();

            Console.WriteLine("\nWhich product u would like to change\n");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Change(p1);
                    break;
                case 2:
                    Change(p2);
                    break; 
                case 3:
                    Change(p3);
                    break;
                default:
                    Console.WriteLine("Error");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }

            Console.Clear();
            p1.PrintProduct();
            p2.PrintProduct();
            p3.PrintProduct();
            Console.ReadKey();
        }

        private static void Change(Product p)
        {
            Console.WriteLine("\nWhat would u like to Change?");
            Console.WriteLine("Press 1 for price");
            Console.WriteLine("Press 2 for amount");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter new value: ");
            var newValue = Convert.ToDouble(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    p.ChangePrice(newValue);
                    break;
                case 2:
                    p.ChangeQuantity((int)newValue);
                    break;
                default:
                    Console.WriteLine("Error");
                    Console.ReadKey();
                    break;
            }
        }
    }
}