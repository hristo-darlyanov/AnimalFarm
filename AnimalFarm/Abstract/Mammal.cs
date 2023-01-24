using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    internal abstract class Mammal : Animal
    {
        public string livingRegion;

        public Mammal(string animalName, string animalType, double animalWeight, int foodEaten) : base(animalName, animalType, animalWeight, foodEaten)
        {
        }

        protected Mammal(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion) : base(animalName, animalType, animalWeight, foodEaten)
        {
            this.livingRegion = livingRegion;
        }
    }
}
