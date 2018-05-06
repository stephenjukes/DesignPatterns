using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class TwoDimensionPrinter : IPrinter
    {
        public void Run()
        {
            Console.WriteLine("Printing in 2D!");
        }
    }
}
