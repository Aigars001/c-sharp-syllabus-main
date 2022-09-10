using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeight, string livingRegion)
            : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("mouse noise?");
        }

        public override void Eat(Food food)
        {
            if (food.GetFoodType() == "Vegetable")
            {
                FoodEaten += food.FoodQuantity;
                Console.WriteLine($"{food.GetFoodType()} {FoodEaten}");
            }
            else
            {
                Console.WriteLine($"{food.GetFoodType()} {food.FoodQuantity}");
                Console.WriteLine($"Mice are not eating that type of food!");
            }
        }
    }
}
