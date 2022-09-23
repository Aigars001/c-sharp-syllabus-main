using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            var audi = new Audi();
            var vaz = new VAZ();
            var toyota = new Toyota();
            var bmw = new Bmw();
            var tesla = new Tesla();
            var lexus = new Lexus();

            var cars = new List<ICar>
            {
                audi, toyota, bmw, tesla, lexus, vaz
            };

            for (int i = 0; i < 10; i++)
            {
                foreach (var car in cars)
                {
                    switch (i)
                    {
                        case 1:
                            car.StartEngine();
                            continue;
                        case 3 when car is IBoost:
                            ((IBoost)car).UseNitrousOxideEngine();
                            continue;
                        default:
                            car.SpeedUp();
                            break;
                    }
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.GetType().Name} : {car.ShowCurrentSpeed}");
            }

            var speed = 0;
            var name = "";

            foreach (var car in cars)
            {
                if (Int32.Parse(car.ShowCurrentSpeed) > speed)
                {
                    speed = Int32.Parse(car.ShowCurrentSpeed);
                    name = car.GetType().Name;
                }
            }

            Console.WriteLine($"{name} with speed of {speed}km/h is the fastest car!");
            Console.ReadKey();
        }
    }
}