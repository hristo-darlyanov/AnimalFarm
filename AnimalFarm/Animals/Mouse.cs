using AnimalFarm.FoodTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.Animals
{
    internal class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion) : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            if (food.GetType() == typeof(Vegetable))
            {
                Console.WriteLine($"{animalType} cannot eat that type of food");
            }
            else
            {
                animalWeight += food.quantity;
                foodEaten += 1;
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("SQUEAAAAAK");
        }

        public override string ToString()
        {
            return $"{animalType}[{animalName}, {animalWeight}, {livingRegion}, {foodEaten}]";
        }
    }
}
