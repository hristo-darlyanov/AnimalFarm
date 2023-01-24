using AnimalFarm.Abstract;
using AnimalFarm.FoodTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.Animals
{
    internal class Cat : Felime
    {
        public Cat(string animalName, string animalType, double animalWeight, int foodEaten) : base(animalName, animalType, animalWeight, foodEaten)
        {
        }

        public override void Eat(Food food)
        {
            animalWeight += food.quantity;
            foodEaten += 1;
        }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
