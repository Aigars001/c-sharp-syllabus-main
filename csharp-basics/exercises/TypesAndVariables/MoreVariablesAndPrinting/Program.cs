using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, eyes, teeth, hair;
            int age, heightInch, weightLB;

            name = "Zed A. Shaw";
            age = 35;
            heightInch = 74;
            weightLB = 180;
            eyes = "Blue";
            teeth = "White";
            hair = "Brown";

            double heightCM = heightInch * 2.54;
            double weightKG = weightLB * 0.453592;

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + heightInch + " inches tall. Which is: " + heightCM + " centimeters");
            Console.WriteLine("He's " + weightLB + " pounds heavy. Which is: " + Math.Round(weightKG,2) + " kilograms");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + age + ", " + heightInch + ", and " + weightLB
                              + " I get " + (age + heightInch + weightLB) + ".");

            Console.ReadKey();
        }
    }
}

