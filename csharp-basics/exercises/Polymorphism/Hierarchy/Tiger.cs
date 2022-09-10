using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Tiger : Feline
    {
        public Tiger(string animalName, string animalType, double animalWeight, string livingRegion)
            : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            if (food.GetFoodType() == "Meat")
            {
                FoodEaten += food.FoodQuantity;
                Console.WriteLine($"{food.GetFoodType()} {FoodEaten}");
            }
            else
            {
                Console.WriteLine($"{food.GetFoodType()} {food.FoodQuantity}");
                Console.WriteLine($"Tigers are not eating that type of food!");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Roar");
        }
    }
}
