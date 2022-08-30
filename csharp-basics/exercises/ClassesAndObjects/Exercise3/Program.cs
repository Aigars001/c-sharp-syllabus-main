using System;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FuelGauge fuel = new FuelGauge();
            Odometer odo = new Odometer(fuel);

            Trip(fuel, odo);
        }

        private static void Trip(FuelGauge fuelGauge, Odometer odometer)
        {
            Console.WriteLine(fuelGauge.checkFuelLevel());

            Fill(fuelGauge);

            Console.WriteLine("Press any key to start the ride");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Range: ");

            while (fuelGauge.ReportFuelLevel() > 0)
            {
                odometer.AddMileage();
                odometer.BurnFuelPerKm();
               
                if (odometer.OdometerReading() % 10 == 0)
                {
                    Console.WriteLine($"fuel level {fuelGauge.ReportFuelLevel()}");
                    Console.WriteLine($"Odometer: {odometer.OdometerReading()}");
                }
            }

            Console.ReadKey();
        }

        private static void Fill(FuelGauge fuel)
        {
            Console.WriteLine("Press 1 to fill up");
            int userInput = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount to fill");
            int fuelAmount = Int32.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Console.Clear();
                if (fuelAmount > 70)
                {
                    while (fuel.ReportFuelLevel() != 70)
                    {
                        fuel.FillUp();
                    }
                    Console.WriteLine("fuel tank Capacity: 70l");
                }
                else
                {
                    while (fuel.ReportFuelLevel() != fuelAmount)
                    {
                        fuel.FillUp();
                    }
                }

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Filling up");
                }

                Console.WriteLine($"fuel level {fuel.ReportFuelLevel()}");
            }
            else
            {
                Console.WriteLine("Exiting...");
                Environment.Exit(0);
            }
        }
    }
}