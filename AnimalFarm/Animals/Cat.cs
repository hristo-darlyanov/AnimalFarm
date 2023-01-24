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
        public string breed;

        public Cat(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion, string breed) : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
            this.breed = breed;
        }

        public override void Eat(Food food)
        {
            foodEaten += food.quantity;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Moewwwww");
        }

        public override string ToString()
        {
            return $"{animalType}[{animalName}, {breed}, {animalWeight}, {livingRegion}, {foodEaten}]";
        }
    }
}
