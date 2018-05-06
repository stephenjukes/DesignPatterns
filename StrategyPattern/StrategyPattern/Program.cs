using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The Strategy Pattern is that an application utilizes interfaces so that different 'strategies' can be swapped in and out without changing the code within the application.

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var threeDimensionPrinter = new ThreeDimensionPrinter();
            var twoDimensionPrinter = new TwoDimensionPrinter();
            var computerA = new Computer(threeDimensionPrinter);
            var computerB = new Computer(twoDimensionPrinter);

            computerA.Print();
            computerB.Print();
        }
    }
}
