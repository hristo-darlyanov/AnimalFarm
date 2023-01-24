using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    internal abstract class Food
    {
        public int quantity;

        protected Food(int quantity)
        {
            this.quantity = quantity;
        }
    }
}
