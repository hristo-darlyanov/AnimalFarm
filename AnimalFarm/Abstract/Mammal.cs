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

        protected Mammal(string animalName, string animalType, double animalWeight, int foodEaten) : base(animalName, animalType, animalWeight, foodEaten)
        {
        }
    }
}
