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
        public Tiger(string animalName, string animalType, double animalWeight, int foodEaten) : base(animalName, animalType, animalWeight, foodEaten)
        {
        }

        public override void Eat(Food food)
        {
            if (food.GetType() == typeof(Meat))
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
            Console.WriteLine("ROAAAR");
        }
    }
}
