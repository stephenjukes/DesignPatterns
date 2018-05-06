using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class ThreeDimensionPrinter : IPrinter
    {
        public void Run()
        {
            Console.WriteLine("Printing in 3D!");
        }
    }
}
