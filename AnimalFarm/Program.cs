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
        static Animal animal = null;
        static Food food = null;
        static List<string> animalInfo;
        static List<string> foodInfo;
        static string animalType;
        static string animalName;
        static double animalWeight;
        static string animalHome;
        static string animalBreed = null;
        static string foodType;
        static int foodQuantity;

        static void Main(string[] args)
        {
            while (true)
            {
                animalInfo = Console.ReadLine().Split(' ').ToList();
                if (animalInfo[0] == "End")
                {
                    Environment.Exit(0);
                }
                foodInfo = Console.ReadLine().Split(' ').ToList();
                animalType = animalInfo[0];
                animalName = animalInfo[1];
                animalWeight = double.Parse(animalInfo[2]);
                animalHome = animalInfo[3];
                animalBreed = null;
                if (animalInfo.Count == 5)
                {
                    animalBreed = animalInfo[4];
                }
                foodType = foodInfo[0];
                foodQuantity = int.Parse(foodInfo[1]);
                ChosenAnimalDoesStuff();
            }
        }

        private static void ChosenAnimalDoesStuff()
        {
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
            Console.WriteLine();
        }
    }
}
