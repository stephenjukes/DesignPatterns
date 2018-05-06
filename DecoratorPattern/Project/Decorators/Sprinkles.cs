using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Sprinkles : Decorator
    {
        private Beverage beverage;
        private int price = 2;

        public Sprinkles(Beverage b)
        {
            beverage = b;
        }

        public override int Cost()
        {
            return this.beverage.Cost() + this.price;
        }
    }
}
