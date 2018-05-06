using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Apple : Computer
    {
        protected override string Name { get; set; } = "Apple";

        protected override void DisplayLogo()
        {
            Console.WriteLine("Display Apple");
        }
    }
}
