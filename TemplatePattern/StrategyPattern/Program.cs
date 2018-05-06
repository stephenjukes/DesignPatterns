using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
The Template Pattern is structurally very similar to the strategy pattern, but involves sub classes inheriting from an abstract class instead of implementing an interface. The difference means that in the Template Pattern, the abstract class can be responsible for functionality that is constant across all subclasses (eg: the structure of a poster) while the subclasses are responsible for functionality that is unique to that subclass (eg: content). It is a essentially a way of keeping code DRY.
*/

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer myComputer = new Linux();
            myComputer.ShowDetails();
        }
    }
}
