using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    internal abstract class Food
    {
        public double quantity;

        protected Food(double quantity)
        {
            this.quantity = quantity;
        }
    }
}
