﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRace
{
    class Program
    {
        /**
 * Take a look at the cars in this solution.
 * 1. Extract common behaviour to an interface called Car, and use it in the all classes.
 * Which methods will be extracted with an empty body, and which can be default?
 * 2. Create two more cars of your own choice.
 * 3. As you see there is a possibility to use some kind of boost in Lexus, extract it to a new interface
          and add that behaviour in one more car.
 * 4. Create one instance of an each car and add them to list.
 * 5. Iterate over the list 10 times, in the 3rd iteration use speed boost on the car if they have one.
 * 6. Print out the car name and speed of the fastest car
 */

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