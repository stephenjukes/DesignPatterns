using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Mocha : Beverage
    {
        public override int Cost()
        {
            return 3;
        }
    }
}
