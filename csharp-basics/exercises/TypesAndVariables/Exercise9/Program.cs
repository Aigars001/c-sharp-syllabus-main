using System;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a distance in meters");
            decimal distanceInMeters = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Write separately how many hours minutes and seconds it took to travel");
            decimal timeInHours = Convert.ToDecimal(Console.ReadLine());
            decimal timeInMinutes = Convert.ToDecimal(Console.ReadLine());
            decimal timeInSeconds = Convert.ToDecimal(Console.ReadLine());

            decimal totalTimeInSeconds = timeInSeconds + (timeInMinutes * 60) + (timeInHours * 60 * 60);
            decimal totalTimeInHours = (totalTimeInSeconds / 60) / 60;
            decimal distanceInKilometers = distanceInMeters / 1000;
            decimal speedKmH = distanceInKilometers / totalTimeInHours;
            decimal speedMilesH = speedKmH / (decimal)1.609;

            Console.WriteLine("Your speed in meters/second is: " + distanceInMeters / totalTimeInSeconds);
            Console.WriteLine("Your speed in km/h is: " + speedKmH);
            Console.WriteLine("Your speed in miles/h is: " + speedMilesH);
        }
    }

}