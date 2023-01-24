using AnimalFarm.Abstract;
using AnimalFarm.FoodTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.Animals
{
    internal class Tiger : Felime
    {
        public string livingRegion;

        public Tiger(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion) : base(animalName, animalType, animalWeight, foodEaten)
        {
            this.livingRegion = livingRegion;
        }

        public override void Eat(Food food)
        {
            if (food.GetType() == typeof(Meat))
            {
                Console.WriteLine($"{animalType} cannot eat that type of food");
            }
            else
            {
                foodEaten += food.quantity;
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAAR");
        }

        public override string ToString()
        {
            return $"{animalType}[{animalName}, {animalWeight}, {livingRegion}, {foodEaten}]";
        }
    }
}
