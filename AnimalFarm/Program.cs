using AnimalFarm.Animals;
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
            List<Animal> animals = new List<Animal>();

            var animalInfo = Console.ReadLine().Split(' ').ToList();
            var foodInfo = Console.ReadLine().Split(' ').ToList();

            string animalType = animalInfo[0].ToLower();
            string animalName = animalInfo[1];
            double animalWeight = double.Parse(animalInfo[2]);
            string animalHomeOrBreed = animalInfo[3];

            string foodType = foodInfo[0];
            int foodQuantity = int.Parse(foodInfo[1]);

            if (animalType == "cat")
            {
                animals.Add(new Cat(animalName, animalType, animalWeight, 0, animalHomeOrBreed));
            }
            else if (animalType == "mouse")
            {
                animals.Add(new Mouse(animalName, animalType, animalWeight, 0, animalHomeOrBreed));
            }
            else if (animalType == "tiger")
            {
                animals.Add(new Tiger(animalName, animalType, animalWeight, 0, animalHomeOrBreed));
            }
            else if (animalType == "zebra")
            {
                animals.Add(new Zebra(animalName, animalType, animalWeight, 0, animalHomeOrBreed));
            }
        }
    }
}
