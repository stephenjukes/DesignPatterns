using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class WhippedCream : Decorator
    {
        private Beverage beverage;
        private int cost = 1;

        public WhippedCream(Beverage b)
        {
            beverage = b;
        }

        public override int Cost()
        {
            return this.beverage.Cost() + this.cost;
        }

    }
}
