using System;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight in KG: ");
            double weightKG = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height in CM: ");
            double heightCM = Convert.ToDouble(Console.ReadLine());

            double weightLbs = weightKG * 2.205;
            double heightInch = heightCM / 2.54;

            double BMI = Math.Round(weightLbs * 703 / Math.Pow(heightInch, 2), 1);

            if (BMI >= 18.5 && BMI <= 25)
            {
                Console.WriteLine("with BMI: " + BMI + " Your weight is optimal!");
            }
            else if (BMI > 25)
            {
                Console.WriteLine("with BMI: " + BMI + " Your are overweight!");
            }
            else if (BMI < 18.5)
            {
                Console.WriteLine("with BMI: " + BMI + " Your are underweight!");
            }
            Console.ReadKey();

        }
    }
}