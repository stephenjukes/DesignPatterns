using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Windows : Computer
    {
        protected override string Name { get; set; } = "Windows";

        protected override void DisplayLogo()
        {
            Console.WriteLine("Display Window");
        }
    }
}
