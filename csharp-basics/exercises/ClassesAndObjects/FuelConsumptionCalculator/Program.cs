using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine();

            Car car1 = new Car(0);
            Car car2 = new Car(0);
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter first reading: ");
                car1.EndKilometers = Convert.ToDouble(Console.ReadLine());    
                Console.Write("Enter liters reading: ");
                car1.Litres = Convert.ToDouble(Console.ReadLine());
                car1.FillUp(car1.EndKilometers, car1.Litres);
                
                Console.Write("Enter first reading: ");
                car2.EndKilometers = Convert.ToInt32(Console.ReadLine());    
                Console.Write("Enter liters reading: ");
                car2.Litres = Convert.ToInt32(Console.ReadLine());
                car2.FillUp(car2.EndKilometers, car2.Litres);
            }

            Console.WriteLine("BMW kilometers per liter are " + Math.Round(car1.CalculateConsumption(),2) + HogOrEco(car1));
            Console.WriteLine("Audi Kilometers per liter are " + Math.Round(car2.CalculateConsumption(),2) + HogOrEco(car2));
            Console.ReadKey();
        }

        private static string HogOrEco(Car carTest)
        {
            return carTest.GasHog() || carTest.EconomyCar() ? " gasHog:" : " economyCar:";
        }
    }
}
