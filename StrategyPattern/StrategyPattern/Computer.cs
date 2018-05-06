using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Computer
    {
        private IPrinter _printer;

        public Computer(IPrinter printer)
        {
            _printer = printer;
        }

        public void Print()
        {
            _printer.Run();
        }
    }
}
