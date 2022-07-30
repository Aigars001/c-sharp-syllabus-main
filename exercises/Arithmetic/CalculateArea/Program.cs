using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = GetMenu();

           if (choice == 1)
           {
               CalculateCircleArea();
           }
           else if (choice == 2)
           {
               CalculateRectangleArea();
           }
           else if (choice == 3)
           {
               CalculateTriangleArea();
           }
           else if (choice == 4)
           {
               Console.WriteLine("Thanks");
               Console.ReadKey();
           }
        }

        public static int GetMenu()
        {

            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
 
            if (userChoice > 4 || userChoice < 1)
            {
                Console.WriteLine("Enter valid number");
                userChoice = Convert.ToInt32(Console.ReadLine());
            }

            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            Console.WriteLine("What is the circle's radius? ");
            decimal radius = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));

            Console.ReadKey();
        }

        public static void CalculateRectangleArea()
        {
            Console.WriteLine("Enter length? ");
            var length = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter width? ");
            var width = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfRectangle(length, width));

            Console.ReadKey();
        }

        public static void CalculateTriangleArea()
        {
            Console.WriteLine("Enter length of the triangle's base? ");
            var ground = Convert.ToDecimal(Console.ReadLine());
   
            Console.WriteLine("Enter triangle's height? ");
            var height = Convert.ToDecimal(Console.ReadLine());
  
            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfTriangle(ground, height));

            Console.ReadKey();
        }
    }
}
