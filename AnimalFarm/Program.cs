using AnimalFarm.Animals;
using AnimalFarm.FoodTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = null;
            Food food = null;

            var animalInfo = Console.ReadLine().Split(' ').ToList();

            if (animalInfo[0] == "End")
            {
                Environment.Exit(0);
            }

            var foodInfo = Console.ReadLine().Split(' ').ToList();

            string animalType = animalInfo[0];
            string animalName = animalInfo[1];
            double animalWeight = double.Parse(animalInfo[2]);
            string animalHome = animalInfo[3];
            string animalBreed = null;

            if (animalInfo.Count == 5)
            {
                animalBreed = animalInfo[4];
            }

            string foodType = foodInfo[0];
            int foodQuantity = int.Parse(foodInfo[1]);

            if (animalType == "Cat")
            {
                animal = new Cat(animalName, animalType, animalWeight, 0, animalHome, animalBreed);
            }
            else if (animalType == "Mouse")
            {
                animal = new Mouse(animalName, animalType, animalWeight, 0, animalHome);
            }
            else if (animalType == "Tiger")
            {
                animal = new Tiger(animalName, animalType, animalWeight, 0, animalHome);
            }
            else if (animalType == "Zebra")
            {
                animal = new Zebra(animalName, animalType, animalWeight, 0, animalHome);
            }
            if (foodType == "Vegetable")
            {
                food = new Vegetable(foodQuantity);
            }
            else if (foodType == "Meat")
            {
                food = new Meat(foodQuantity);
            }

            animal.MakeSound();
            animal.Eat(food);
            Console.WriteLine(animal.ToString());
        }
    }
}
